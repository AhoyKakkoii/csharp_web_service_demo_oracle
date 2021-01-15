using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Xml;

namespace WebService1_demo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            WebService_CRUD_demo_Reference.WebService1SoapClient client = new WebService_CRUD_demo_Reference.WebService1SoapClient();
            String result = client.Appr_Div_Summary(Convert.ToString(txtAppr.Text), Convert.ToString(txtStartDate.Text), Convert.ToString(txtEndDate.Text), Convert.ToString(txtBfy.Text));
            
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(result);
            DataSet ds = new DataSet();
            XmlNodeReader xmlreader = new XmlNodeReader(xmlDoc);
            ds.ReadXml(xmlreader, XmlReadMode.Auto);
            ApprDivSummaryGridView.DataSource = ds;
            ApprDivSummaryGridView.DataBind();
        }
    }
}