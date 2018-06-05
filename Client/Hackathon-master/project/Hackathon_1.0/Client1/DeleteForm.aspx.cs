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
            obj.Vehicle_No = TextBox1.Text.ToLower();
            var Url = "http://localhost:1587/api/values/"+obj.Vehicle_No;
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(Url);
            request.Method = "DELETE";
            //request.ContentType = "application/json";
            //string json = JsonConvert.SerializeObject(obj);
            //ASCIIEncoding encoding = new ASCIIEncoding();
            //byte[] byte1 = encoding.GetBytes(json);
            //Stream newStream = request.GetRequestStream();
            //newStream.Write(byte1, 0, byte1.Length);

            var httpResponse = (HttpWebResponse)request.GetResponse();
            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Deleted successfully');</script>");
            }

        }
    }
    
}