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

namespace FutureOfRetail.Controllers
{
    public partial class BeaconController : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        [ScriptMethod(UseHttpGet = true)]
        public static Beacon GetBeaconById(int id)
        {
            //html encode
            return BeaconService.GetBeaconData(id);
        }

    }
}