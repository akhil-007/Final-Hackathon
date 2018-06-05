using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using System.Net;
using Newtonsoft.Json;
using System.Text;
using System.IO;

namespace Client1
{
    public partial class Transaction1 : System.Web.UI.Page
    {
        Transaction obj = new Transaction();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            obj.Trip_Id= Int32.Parse(TextBox1.Text);
            obj.Vehicle_No = TextBox2.Text.ToLower();
            obj.Address_Start= TextBox3.Text.ToLower();
            obj.Address_End = TextBox4.Text.ToLower();
            /* obj.Gps_Start =;
             obj.Gps_End=;
             obj.Ride_Type =;*/
            if (Request.Form["RideType"] != null)
            {
                obj.Ac = Request.Form["AC"].ToString();
                //  Label1.Text = Request.Form["AC"].ToString();
            }

            obj.Fuel_Cost_Litre = float.Parse(TextBox5.Text.ToLower(), CultureInfo.InvariantCulture.NumberFormat);
            obj.Distance = float.Parse(TextBox6.Text.ToLower(), CultureInfo.InvariantCulture.NumberFormat);
           // obj.Start_Date =;
           // obj.End_Date =;
            //string value = "";
            if (Request.Form["AC"] != null)
            {
                obj.Ac = Request.Form["AC"].ToString();
              //  Label1.Text = Request.Form["AC"].ToString();
            }
            if (Request.Form["RideType"] != null)
            {
                obj.Ac = Request.Form["RideType"].ToString();
                 Label1.Text = Request.Form["RideType"].ToString();
            }

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
                
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Data inserted successfully');</script>");
                

                //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Inserted Successfully')", true);
            }
            
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
             
           // obj.Start_Date = DateTime.ParseExact(Calendar1.SelectedDate.ToShortDateString(), "MM-dd-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        }
        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
          // obj.End_Date = DateTime.ParseExact(Calendar2.SelectedDate.ToShortDateString(), "MM-dd-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        }
    }
}