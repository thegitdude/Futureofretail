using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using FutureOfRetail.Service;
using FutureOfRetail.Model;

namespace FutureOfRetail.Controllers
{
    public partial class BarcodeController : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        [ScriptMethod(UseHttpGet = true)]
        public static Product GetProductByCode(string code)
        {
            //html encode
            return ProductService.GetProductsByCode(code);
        }
    }
}