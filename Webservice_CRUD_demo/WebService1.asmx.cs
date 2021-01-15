using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Webservice_CRUD_demo
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://www.shaw-yu.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        private DBInfo objDb = new DBInfo();

        [WebMethod(Description = "GET APPR DIV SUMMARY")]
        public String Appr_Div_Summary(String appr, String start_date, String end_date, String bfy)
        {
            try
            {
                return objDb.GetApprDivSummary(appr, start_date, end_date, bfy);
            }
            catch (Exception e)
            {
                throw new ApplicationException("ERROR: Cannot Get APPR DIV SUMMARY: "
                    + e.Message);
            }
        }
    }
}
