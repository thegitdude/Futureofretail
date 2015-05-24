using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using FutureOfRetail.Model;
using FutureOfRetail.Tools;

namespace FutureOfRetail.Service
{
    public class StatisticService
    {
        public static void AddEvent(string tag)
        {
            try
            {
                using (var sqlCon = ConnectionClass.GetCon())
                {
                    var orderHistoryEntries =
                        sqlCon.Execute(String.Format(@"Insert into [{0}].[dbo].[Statistic] 
                        (CreatedDate, EventType) Values 
                        (@created, @eventType)", ConnectionClass.sampleDatabaseName), new
                                                            {
                                                                created = DateTime.Now,
                                                                eventType = tag,
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

        public static StatisticViewModel GetDataForTag(string tag)
        {
            var statistics = new List<Statistic>();
            try
            {
                using (var sqlCon = ConnectionClass.GetCon())
                {
                    statistics =
                        sqlCon.Query<Statistic>(String.Format(@"
                        DECLARE @Now DATETIME = GETDATE();
                        DECLARE @7DaysAgo DATETIME = DATEADD(day,-7,@Now);
                        select  [Id], [CreatedDate], [EventType]
                        FROM Statistic where
                        createdDate < CONVERT(datetime,@Now) 
						AND convert(datetime,createdDate) > CONVERT(datetime,@7DaysAgo)
						AND EventType=@tag ", ConnectionClass.sampleDatabaseName), new { tag = tag }).ToList();

                    // Do something with the results:
                    // Additional code here...
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return GenerateStatistics(statistics);
        }

        private static StatisticViewModel GenerateStatistics(List<Statistic> statistics)
        {
            var statisticsViewModel = new StatisticViewModel();
            statisticsViewModel.datasets = new List<DataSet>();
            var set = new DataSet();
            set.fillColor = "";
            statisticsViewModel.labels = new List<string>();
            set.data = new List<int>();
            set.fillColor = "#382765";
            for (int i = 0; i < 7; i++)
            {
                int count = 0;
                var date = DateTime.Now;
                double test = -1 * i;
               date= date.AddDays(test);
                statisticsViewModel.labels.Add(date.ToString());
                set.label = "test";
               
                foreach (var s in statistics)
                {
                    if (s.CreatedDate.Day == date.Day)
                        count++;
                }
                set.data.Add(count);
            }
            statisticsViewModel.datasets.Add(set);
            return statisticsViewModel;
        }

    }
}