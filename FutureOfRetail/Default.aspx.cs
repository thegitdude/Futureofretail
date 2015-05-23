using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using FutureOfRetail.Model;
using FutureOfRetail.Service;

namespace FutureOfRetail
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true)]
        public static List<RetailArea> GetRetailAreas()
        {
           return RetailAreaService.GetShopAreas();
        }

    }
}