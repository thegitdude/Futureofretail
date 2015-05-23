using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using FutureOfRetail.Model;
using FutureOfRetail.Tools;


namespace FutureOfRetail.Service
{
    public class RetailAreaService
    {
        public static List<RetailArea> GetShopAreas()
        {
            List<RetailArea> areas = new List<RetailArea>();
            try
            {
                using (var sqlCon = ConnectionClass.GetCon())
                {
                    areas =
                        sqlCon.Query<RetailArea>(String.Format(@"SELECT * from FROM [{0}].[dbo].[RetailArea]",
                        ConnectionClass.sampleDatabaseName)).ToList();

                    // Do something with the results:
                    // Additional code here...
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return areas;
        }

    }
}