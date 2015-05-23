using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FutureOfRetail.Model
{
    public class Product
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public string Description { get; set; }

        public string Url { get; set; }

        public string ShopId { get; set; }
    }
}