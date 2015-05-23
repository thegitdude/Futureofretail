using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using FutureOfRetail.Model;
using FutureOfRetail.Tools;

namespace FutureOfRetail.Service
{
    public class ProductService
    {
        public static void AddProduct(Product p)
        {
            p.Name = HttpUtility.HtmlEncode(p.Name);

            try
            {
                using (var sqlCon = ConnectionClass.GetTrafficButtyCon())
                {
                    var orderHistoryEntries =
                        sqlCon.Execute(String.Format(@"Insert into [{0}].[dbo].[Product] 
                        (Name, Description, Url, ShopId) Values 
                        (@name, @descriprion, @url, @shopId)", ConnectionClass.sampleDatabaseName), new
                                                                       {
                                                                           name = p.Name,
                                                                           descriprion = p.Description,
                                                                           url = p.Url,
                                                                           shopId = p.ShopId
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

        public static List<Product> GetProductsByQuerry(string productName)
        {
            List<Product> questions = new List<Product>();
            try
            {
                using (var sqlCon = ConnectionClass.GetTrafficButtyCon())
                {
                    questions =
                        sqlCon.Query<Product>(String.Format(@"SELECT TOP 20 [Id], [Name], [Description], [Url], [ShopId]
                                                 FROM [{0}].[dbo].[Product] where name LIKE '%@productName%'",new {ProductName=productName}, ConnectionClass.sampleDatabaseName)).ToList();

                    // Do something with the results:
                    // Additional code here...
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return questions;
        }

        public static void AddTagForProductId(int productId, string tagName)
        {
            try
            {
                using (var sqlCon = ConnectionClass.GetTrafficButtyCon())
                {
                    var orderHistoryEntries =
                        sqlCon.Execute(String.Format(@"Insert into [{0}].[dbo].[Tag] 
                        (ProductId, TagName) Values 
                        (@productId, @tagName)", ConnectionClass.sampleDatabaseName), new
                                                                       {
                                                                           productId = productId,
                                                                           tagName = tagName
                                                                       });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
    }
    }
}