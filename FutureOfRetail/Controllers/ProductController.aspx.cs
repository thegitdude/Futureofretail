using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using FutureOfRetail.Service;
using FutureOfRetail.Model;
using System.Web.Script.Services;

namespace FutureOfRetail.Controllers
{
    public partial class ProductController : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        public static void AddProduct(Product p)
        {
             ProductService.AddProduct(p);
        }
    }
}