using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client1
{
    public partial class DeleteForm : System.Web.UI.Page
    {
        Vehicle obj = new Vehicle();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            obj.Vehicle_No = TextBox1.Text.ToUpper();
            var Url = "http://localhost:3033/api/values/"+obj.Vehicle_No;
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(Url);
            request.Method = "DELETE";

            var httpResponse = (HttpWebResponse)request.GetResponse();
            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Deleted successfully');</script>");
            }

        }
    }
    
}