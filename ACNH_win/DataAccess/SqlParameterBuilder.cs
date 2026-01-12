using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACNH_win.Helpers
{
	public class SqlParameterBuilder
	{
		private List<SqlParameter> _parameters = new List<SqlParameter>();
		
		public SqlParameterBuilder AddInt(string name, int value)
		{
			var p = new SqlParameter(name, System.Data.SqlDbType.Int) { Value = value };
			
			_parameters.Add(p);
			return this;
		}

		public SqlParameterBuilder AddBool(string name, bool value)
		{
			var p = new SqlParameter(name, System.Data.SqlDbType.Bit) { Value = value };

			_parameters.Add(p);
			return this;
		}
		public SqlParameterBuilder AddDateTime(string name, DateTime value)
		{
			var p = new SqlParameter(name, System.Data.SqlDbType.DateTime) { Value = value };
			_parameters.Add(p);
			return this;
		}
		public SqlParameterBuilder AddNVarChar(string name, int size ,string value)
		{
			var p = new SqlParameter(name, System.Data.SqlDbType.NVarChar, size) { Value = value };
			_parameters.Add(p);
			return this;
		}
		public SqlParameterBuilder AddVarChar(string name, string value, int size)
		{
			var p = new SqlParameter(name, System.Data.SqlDbType.VarChar, size) { Value = value };
			_parameters.Add(p);
			return this;
		}
		public SqlParameter[] ToArry()
		{
			return _parameters.ToArray();
		}	
	}
}
