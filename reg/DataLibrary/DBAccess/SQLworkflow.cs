using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.DBAccess
{
    class SQLworkflow
    {
        public static string getstringconnection()
        {
            return ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }
        
        public static List<T> loadData<T>(string sql)
        {
            using (IDbConnection conn = new SqlConnection(getstringconnection()))
            {
                return conn.Query<T>(sql).ToList();
            }
        }
        public static void saveData<T>(string sql, T data)
        {
            using (IDbConnection conn = new SqlConnection(getstringconnection()))
            {
                conn.Execute(sql, data);
            }
        }
    }
}
