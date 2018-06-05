using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        Vehicle obj = new Vehicle();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "")
            {
                Label1.Text = "Please Select a Wheel Type";
                DropDownList2.Enabled = false;
            }
            else
            {
                DropDownList2.Items.Clear();
                string check = DropDownList1.SelectedValue.Replace(" ", "");
                if (check == "2")
                {
                    DropDownList2.Items.Add("Bike");
                    DropDownList2.Items.Add("Scooty");
                }
                else
                {
                    DropDownList2.Items.Add("Hatchback");
                    DropDownList2.Items.Add("Sedan");
                    DropDownList2.Items.Add("SUV");
                }
            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           // Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Vehicle Details added successfully');</script>");
            
            obj.Vehicle_No = TextBox1.Text.ToLower();
            obj.Wheel_Type = Int32.Parse((DropDownList1.SelectedValue.ToString()));
            obj.Vehicle_Type = DropDownList2.SelectedValue.Replace(" ", "").ToLower();
            obj.Year = Int32.Parse(TextBox3.Text);
            obj.Model = TextBox4.Text.ToLower();
            obj.Manufacturer = TextBox5.Text.ToLower();
            obj.Fuel_Capacity = TextBox6.Text.ToLower();


            var Url = "http://localhost:1587/api/values/";
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(Url);
            request.Method = "POST";
            request.ContentType = "application/json";
            string json = JsonConvert.SerializeObject(obj);
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] byte1 = encoding.GetBytes(json);
            Stream newStream = request.GetRequestStream();
            newStream.Write(byte1, 0, byte1.Length);

            var httpResponse = (HttpWebResponse)request.GetResponse();
            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Vehicle Details added successfully');</script>");
            }
           
        }
    }
}
