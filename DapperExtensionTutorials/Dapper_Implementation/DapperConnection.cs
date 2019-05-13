using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;
using DapperExtensionTutorials.Models;

namespace DapperExtensionTutorials.Dapper_Implementation
{
    public class DapperConnection<T> where T:class
    {
        private static string Connect = @"Data Source=PCZ-EE211138\SQLEXPRESS;Initial Catalog=Tutorials;Integrated Security=True";
        public static List<T> GetAll()
        {
            List<T> Data=new List<T>();
            using (IDbConnection connection = new SqlConnection(Connect))
            {
                connection.Open();
                string Query = @"Select * from SampleEmployee";
                Data= connection.Query<T>(Query).ToList();
            }
            return Data;
        }

    }
}