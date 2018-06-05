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
using System.Text.RegularExpressions;

namespace Client1
{
    public partial class Transaction1 : System.Web.UI.Page
    {
        Transaction obj = new Transaction();
        string date1;
        string date2;
        string time1;
        string time2;
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Calendar1.Visible = true;
            
           // obj.Trip_Id= Int32.Parse(TextBox1.Text);
            obj.Vehicle_No = TextBox2.Text.ToUpper();
            obj.Address_Start= TextBox3.Text.ToLower();
            obj.Address_End = TextBox4.Text.ToLower();
            
             time1 = txtTime.Text.ToLower();
            time2 = TextBox8.Text.ToLower();
            /* obj.Gps_Start =;
             obj.Gps_End=;
             obj.Ride_Type =;*/
           /* if (Request.Form["RideType"] != null)
            {
                obj.Ac = Request.Form["AC"].ToString();
                //  Label1.Text = Request.Form["AC"].ToString();
            }*/
            obj.Ride_Type= DropDownList1.SelectedValue.ToString(); 
            obj.Fuel_Cost_Litre = float.Parse(TextBox5.Text.ToLower(), CultureInfo.InvariantCulture.NumberFormat);
            obj.Distance = float.Parse(TextBox6.Text.ToLower(), CultureInfo.InvariantCulture.NumberFormat);
           // obj.Start_Date =;
           // obj.End_Date =;
            //string value = "";
           /* if (Request.Form["AC"] != null)
            {
                obj.Ac = Request.Form["AC"].ToString();
              //  Label1.Text = Request.Form["AC"].ToString();
            }
            if (Request.Form["RideType"] != null)
            {
                obj.Ac = Request.Form["RideType"].ToString();
                
            }*/
            obj.AC = DropDownList1.SelectedValue.ToString();
            obj.Fuel = Int32.Parse(TextBox7.Text.ToLower());
            string dt1= Calendar1.SelectedDate.ToString("yyyy-MM-dd");
            time1 = txtTime.Text.ToLower();
            dt1 = dt1 + " " + time1;
            obj.Start_Date = DateTime.ParseExact(dt1, "yyyy-MM-dd HH:mm:ss", null);
            string dt = Calendar2.SelectedDate.ToString("yyyy-MM-dd");
            time2 = TextBox8.Text.ToLower();
            string result = Regex.Match(dt, "^[^ ]+").Value;
            dt = result + " " + time2;

            //date2=date2.Replace("\"", "");

            obj.End_Date = DateTime.ParseExact(dt, "yyyy-MM-dd HH:mm:ss", null);
            var Url = "http://localhost:3033/api/transaction/";
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

        
    }
}