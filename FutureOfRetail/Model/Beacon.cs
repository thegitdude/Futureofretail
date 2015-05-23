using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FutureOfRetail.Model
{
    public class Beacon
    {
        public int Id { get; set; }

        public int BeaconID { get; set; }

        public int RetailAreaID { get; set; }

        public int ShopId { get; set; }
    }
}
