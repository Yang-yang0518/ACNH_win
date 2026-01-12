using System.Security.Cryptography;

namespace ACNH_win.Security
{
    public static class PasswordHasher
    {
        public const int SaltSize = 16;
        public const int KeySize = 32;
        public const int DefaultIterations = 100_000;

        public static (byte[] hash, byte[] salt, int iterations) HashPassword(string password)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(SaltSize);

            using var pbkdf2 = new Rfc2898DeriveBytes(
                password,
                salt,
                DefaultIterations,
                HashAlgorithmName.SHA256
            );

            byte[] hash = pbkdf2.GetBytes(KeySize);
            return (hash, salt, DefaultIterations);
        }

        public static bool VerifyPassword(string password, byte[] salt, int iterations, byte[] expectedHash)
        {
            using var pbkdf2 = new Rfc2898DeriveBytes(
                password,
                salt,
                iterations,
                HashAlgorithmName.SHA256
            );

            byte[] actualHash = pbkdf2.GetBytes(KeySize);
            return CryptographicOperations.FixedTimeEquals(actualHash, expectedHash);
        }
    }
}
