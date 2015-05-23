﻿using System;
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
                        (@beaconId, @retailAreaId, @shopId)", ConnectionClass.sampleDatabaseName), new
                                                             {
                                                                 beaconId =b.BeaconID,
                                                                 retailAreaId = b.RetailAreaID,
                                                                 shopID= b.ShopId,
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
                                                 FROM [{0}].[dbo].[Beacon] where BeaconId =@beaconId", new { beaconId = beaconId }, ConnectionClass.sampleDatabaseName)).FirstOrDefault();

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

    }
}