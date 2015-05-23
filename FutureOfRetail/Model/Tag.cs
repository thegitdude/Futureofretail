using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FutureOfRetail.Model
{
    public class Tag
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string TagName { get; set; }
    }
}