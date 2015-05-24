using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FutureOfRetail.Tools;
using FutureOfRetail.Model;
using Dapper;

namespace FutureOfRetail.Service
{
    public class BeaconService
    {
        public static void AddBeacon(Beacon b)
        {
            try
            {
                using (var sqlCon = ConnectionClass.GetCon())
                {
                    var orderHistoryEntries =
                        sqlCon.Execute(String.Format(@"Insert into [{0}].[dbo].[Beacon] 
                        (BeaconId, RetailAreaId, ShopId) Values 
                        (@beaconId, (select id from retailArea where name=@retailAreaName), @shopId)", ConnectionClass.sampleDatabaseName), new
                                                             {
                                                                 beaconId = b.BeaconID,
                                                                 retailAreaId = b.RetailAreaID,
                                                                 shopID = b.ShopId,
                                                                 retailAreaName = b.RetailAreaName
                                                             });

                    // Do something with the results:
                    // Additional code here...
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static Beacon GetBeaconData(int beaconId)
        {
            var beacon = new Beacon();
            try
            {
                using (var sqlCon = ConnectionClass.GetCon())
                {
                    beacon =
                        sqlCon.Query<Beacon>(String.Format(@"SELECT TOP 1 [Id], [BeaconId], [RetailAreaId], [ShopId]
                                                 FROM [{0}].[dbo].[Beacon] where BeaconId =@beaconId", ConnectionClass.sampleDatabaseName), new { beaconId = beaconId }).FirstOrDefault();

                    // Do something with the results:
                    // Additional code here...
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return beacon;
        }

        public static List<RetailArea> GetShopAreas(int beaconId)
        {
            var areas = new List<RetailArea>();
            try
            {
                using (var sqlCon = ConnectionClass.GetCon())
                {
                    areas =
                        sqlCon.Query<RetailArea>(String.Format(@"SELECT r.id, r.name 
                        FROM [{0}].[dbo].[Beacon] b
                        INNER JOIN [{0}].[dbo].[shopMap] s
                        ON b.shopId=s.ShopId
                        INNER JOIN [{0}].[dbo].[RetailArea] r
                        ON r.id=s.retailAreaid
                        where b.beaconid=@beaconId", ConnectionClass.sampleDatabaseName), new { beaconId = beaconId }).ToList();

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
        public static List<BeaconData> GetAllBeacons()
        {
            List<BeaconData> beacons = new List<BeaconData>();
            try
            {
                using (var sqlCon = ConnectionClass.GetCon())
                {
                    beacons =
                        sqlCon.Query<BeaconData>(String.Format(@"SELECT b.BeaconId, r.Name as ShopAreaName, s.Name as ShopName
                        FROM dbo.Beacon b JOIN RetailArea r 
                        ON b.RetailAreaId = r.Id JOIN Shop s ON b.shopId = s.id ",
                        ConnectionClass.sampleDatabaseName)).ToList();



                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            return beacons;
        }
    }
}