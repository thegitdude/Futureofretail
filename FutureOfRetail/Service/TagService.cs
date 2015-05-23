using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using FutureOfRetail.Model;
using FutureOfRetail.Tools;

namespace FutureOfRetail.Service
{
    public class TagService
    {
        public static void AddTag(Tag tag)
        {
            tag.TagName = HttpUtility.HtmlEncode(tag.TagName);
            

            try
            {
                using (var sqlCon = ConnectionClass.GetCon())
                {
                    var orderHistoryEntries =
                        sqlCon.Execute(String.Format(@"Insert into [{0}].[dbo].[Tag] 
                        (ProductId, TagName) Values 
                        (@productid, @tagname)", ConnectionClass.sampleDatabaseName), new
                                             {
                                                 productid = tag.ProductId,
                                                 tagname = tag.TagName,
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