using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FutureOfRetail.Model
{
    public class ShopArea
    {
        public int Id { get; set; }
        public int AreaId { get; set; }
        public int ShopId { get; set; }
        public string Name { get; set; }

    }
}