using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using FutureOfRetail.Model;
using FutureOfRetail.Tools;

namespace FutureOfRetail.Service
{
    public class ShopService
    {
        public static void AddShop(Shop shop)
        {
            shop.Name = HttpUtility.HtmlEncode(shop.Name);

            try
            {
                using (var sqlCon = ConnectionClass.GetCon())
                {
                    var orderHistoryEntries =
                        sqlCon.Execute(String.Format(@"Insert into [{0}].[dbo].[Shop] 
                        (Name, Type, Url) Values 
                        (@name, @type, @url)", ConnectionClass.sampleDatabaseName), new
                                                             {
                                                                 name = shop.Name,
                                                                 type = shop.Type,
                                                                 url = shop.Url,                                                                
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

    }
}