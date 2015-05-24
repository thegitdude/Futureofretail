using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FutureOfRetail.Model;
using FutureOfRetail.Service;
using System.Web.Services;
using System.Web.Script.Services;

namespace FutureOfRetail.Controllers
{
    public partial class StatisticsController : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true)]
        public static StatisticViewModel GetStatistics(string tag)
        {
            return StatisticService.GetDataForTag(tag);
        }
    }
}