using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FutureOfRetail.Model
{
    public class StatisticViewModel
    {
        public List<string> labels { get; set; }

        public List<DataSet> datasets { get; set; }
    }
    public class DataSet {
        public string label { get; set; }
        public string fillColor { get; set; }
        public List<int > data { get; set; }
    }
}