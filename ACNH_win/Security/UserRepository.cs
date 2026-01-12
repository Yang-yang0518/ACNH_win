using Microsoft.Data.SqlClient;
using System.Data;

namespace ACNH_win.Security
{
    public static class UserRepository
    {
        public static void CreateUser(string connStr, string username, string password)
        {
            var (hash, salt, it) = PasswordHasher.HashPassword(password);

            string sql = @"
INSERT INTO dbo.Users(Username, PasswordHash, PasswordSalt, Iterations)
VALUES(@Username, @Hash, @Salt, @It);";

            using var conn = new SqlConnection(connStr);
            conn.Open();

            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.Add("@Hash", SqlDbType.VarBinary, 32).Value = hash;
            cmd.Parameters.Add("@Salt", SqlDbType.VarBinary, 16).Value = salt;
            cmd.Parameters.AddWithValue("@It", it);

            cmd.ExecuteNonQuery();
        }

        public static bool TryLogin(string connStr, string username, string password, out int userId)
        {
            userId = 0;

            string sql = @"
SELECT TOP 1 Id, PasswordHash, PasswordSalt, Iterations
FROM dbo.Users
WHERE Username = @Username AND IsActive = 1;";

            using var conn = new SqlConnection(connStr);
            conn.Open();

            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Username", username);

            using var reader = cmd.ExecuteReader();
            if (!reader.Read()) return false;

            int id = reader.GetInt32(reader.GetOrdinal("Id"));
            byte[] hash = (byte[])reader["PasswordHash"];
            byte[] salt = (byte[])reader["PasswordSalt"];
            int it = reader.GetInt32(reader.GetOrdinal("Iterations"));

            bool ok = PasswordHasher.VerifyPassword(password, salt, it, hash);
            if (!ok) return false;

            userId = id;
            return true;
        }

    }
}
