using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace FutureOfRetail.Tools
{
    public class ConnectionClass
    {
        private static SqlConnectionStringBuilder dbString;
        private static readonly string userName = "mysite1";
        private static readonly string password = "Zt4Tu3#<8Lyd";
        private static readonly string dataSource = "mssql1.gear.host"; //database server, etc.
        public static readonly string sampleDatabaseName = "ourlittlethings"; //i.e. "master", etc.
        public static readonly string sampleDatabaseNameCloud = "mysite1"; //i.e. "master", etc.
        private static string constr = @"Server=mssql1.gear.host;Database=retail;User Id=ourlittlethings;Password=Ym3c9!0#TA7H";
        private static string constrLocal = @"Server=ASUS\SQLEXPRESS;Database=retail;Trusted_Connection=Yes";


        public static SqlConnection GetTrafficButtyCon()
        {
            try
            {
                // Execute the user defined function or stored procedure and fetch the
                // matching results:
                var conn = new SqlConnection(constrLocal);
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