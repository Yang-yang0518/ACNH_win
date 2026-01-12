using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACNH_win.Helpers
{
	public class DbHelper
	{
		private readonly string _connStr;
		
		public DbHelper(string connStr)
		{
			this._connStr = connStr;
		}

		public int ExecuteNonQuery(string sql, params SqlParameter[] parameters)
		{
			int rowAffected = 0;

			using (SqlConnection conn = new SqlConnection(_connStr))
			{
				try
				{
					conn.Open();

					using (SqlCommand cmd = new SqlCommand(sql, conn))
					{
						if (parameters.Length > 0)
						{
							cmd.Parameters.AddRange(parameters);

						}
						rowAffected = cmd.ExecuteNonQuery();
					}
				}

				catch (Exception ex)
				{
					Console.WriteLine("操作失敗,原因:" + ex.Message);
					rowAffected = 0;
				}
			}
			return rowAffected;
		}

		public T Load<T>(Func<SqlDataReader, T> mapper, string sql, params SqlParameter[] parameters) where T : class
		{
			T result = default;
			using (SqlConnection coon = new SqlConnection(_connStr))

			{
				try
				{
					coon.Open();


					using (SqlCommand cmd = new SqlCommand(sql, coon))
					{
						if (parameters != null && parameters.Length > 0)
						{
							cmd.Parameters.AddRange(parameters);
						}


						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							if (reader.Read())
							{
								result = mapper(reader);
							}
						}
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine("操作失敗,原因:" + ex.Message);
				}

				{ return result; }
			}
		}

		public IEnumerable<T> Query<T>(Func<SqlDataReader, T> mapper, string sql, params SqlParameter[] parameters) where T : class

		{
			//List<T> result = new List<T>();

			using (SqlConnection conn = new SqlConnection(_connStr))
			{
				//try
				//{
				conn.Open();


				using (SqlCommand cmd = new SqlCommand(sql, conn))
				{
					if (parameters != null && parameters.Length > 0)
					{
						cmd.Parameters.AddRange(parameters);
					}


					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							yield return mapper(reader);
							//result.Add(mapper(reader));

						}
					}
				}
				//}
				//catch (Exception ex)
				//{
				//	Console.WriteLine("操作失敗,原因:" + ex.Message);
				//	yield break;
				//}
			}
		}
	}
}
