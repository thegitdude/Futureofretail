using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace FutureOfRetail.Tools
{
    public class ConnectionClass
    {
        public static readonly string sampleDatabaseName = "futureofretail"; //i.e. "master", etc.
        public static readonly string sampleDatabaseNameCloud = "futureofretail"; //i.e. "master", etc.
        private static string constr = @"Server=mssql1.gear.host;Database=retail;User Id=futureofretail;Password=Lf2b9iC#^y8A";
        private static string constrLocal = @"Server=ASUS\SQLEXPRESS;Database=retail;Trusted_Connection=Yes";


        public static SqlConnection GetTrafficButtyCon()
        {
            try
            {
                // Execute the user defined function or stored procedure and fetch the
                // matching results:
                var conn = new SqlConnection(constr);
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}