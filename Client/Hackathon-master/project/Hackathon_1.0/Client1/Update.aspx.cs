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
    public partial class Update : System.Web.UI.Page
    {
        Vehicle obj = new Vehicle();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel1.Enabled = false;

        }

        protected void Unnamed1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            obj.Vehicle_No = vehicle_number.Text.ToLower();
            obj.Wheel_Type = Int32.Parse(DropDownList1.SelectedValue);
            obj.Vehicle_Type = DropDownList2.SelectedValue.ToLower();
            obj.Year=Int32.Parse(TextBox3.Text);
            obj.Model = TextBox4.Text.ToLower();
            obj.Manufacturer=TextBox5.Text.ToLower();
            obj.Fuel_Capacity = TextBox6.Text.ToLower();
            var Url = "http://localhost:1587/api/values/";
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(Url);
            request.Method = "PUT";
            request.ContentType = "application/json";
            string json = JsonConvert.SerializeObject(obj);
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] byte1 = encoding.GetBytes(json);
            Stream newStream = request.GetRequestStream();
            newStream.Write(byte1, 0, byte1.Length);

            var httpResponse = (HttpWebResponse)request.GetResponse();
            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Vehicle Details updated successfully');</script>");
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string result = "";
             obj.Vehicle_No = vehicle_number.Text.ToLower();
            var Url = "http://localhost:1587/api/values/" + obj.Vehicle_No;
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(Url);
            request.Method = "GET";
            var httpResponse = (HttpWebResponse)request.GetResponse();
            if(httpResponse.StatusCode==HttpStatusCode.OK)
            {
                Panel1.Enabled = true;
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }
                Vehicle master = Newtonsoft.Json.JsonConvert.DeserializeObject<Vehicle>(result);
                if (master.Wheel_Type == 2)
                {
                    DropDownList2.Items.Clear();
                    DropDownList1.SelectedValue = "2";
                    DropDownList2.Items.Add("Scooty");
                    DropDownList2.Items.Add("Bike");
                   

                }
                else
                {
                    DropDownList2.Items.Clear();
                    DropDownList1.SelectedValue = "4";
                    DropDownList2.Items.Add("Hatchback");
                    DropDownList2.Items.Add("Sedan");
                    DropDownList2.Items.Add("SUV");
                    

                }
                DropDownList2.SelectedValue = master.Vehicle_Type;
                TextBox3.Text = master.Year.ToString();
                TextBox4.Text = master.Model;
                TextBox5.Text = master.Manufacturer;
                TextBox6.Text = master.Fuel_Capacity.ToString();



            }
            else
            {

            }


        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
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
}