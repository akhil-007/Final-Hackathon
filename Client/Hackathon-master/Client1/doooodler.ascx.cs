using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client1
{
    public partial class doooodler : System.Web.UI.UserControl
    {
        string[] details = new string[11];// = { "Innove", "SUV", "", "5", "Diesel", "8", "10" };
        double max_milage = 0;

        public void get_data_transaction(string ID)
        {
            var result = "";
            var Url = "http://localhost:3033/api/transaction/" + ID;
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(Url);
            request.Method = "GET";
            var httpResponse = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }
            var list = JsonConvert.DeserializeObject<List<Transaction>>(result);
            if (list.Count != 0)
            {
                details[5] = list[0].Mileage.ToString();
                details[6] = list[0].Rate_km.ToString();
            }
            else
            {
                details[5] = "0";
                details[6] = "0";
            }
            
        }

        public void get_data_master(string ID)
        {
            var result = "";
            var Url = "http://localhost:3033/api/values/" + ID;
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(Url);
            request.Method = "GET";
            var httpResponse = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }
            var list = JsonConvert.DeserializeObject<Vehicle>(result);
            details[0] = list.Model;
            details[1] = list.Vehicle_Type;
            details[2] = list.Vehicle_No;
            details[3] = list.Year.ToString();
            details[4] = list.Fuel_Capacity;

           

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            get_data_master(this.ID);
            get_data_transaction(this.ID);
            details[1] = details[1].ToLower();

            switch (details[1]) 
            {
                case "suv": max_milage = 10; Image1.ImageUrl = "http://chittagongit.com//images/suv-icon/suv-icon-0.jpg"; break;
                case "sedan": max_milage = 13; Image1.ImageUrl = "http://www.premiumleasing.com.sg/wp-content/uploads/Silhouette-Medium-sized-Sedan-1-1-960x500.png"; break;
                case "hatchback": max_milage = 16; Image1.ImageUrl = "http://freevector.co/wp-content/uploads/2009/02/55308-car-of-hatchback-model.png"; break;
            }
            Chart1.Series[0].Points.Clear();
            double tempz = Double.Parse(details[5]) / max_milage * 100;

            Chart1.Series[0].Points.AddXY("milage %", tempz);
            Chart1.Series[0].Points[0].AxisLabel = (tempz).ToString(".0") + "%";
            Chart1.Series[0].Points.AddXY("", 100 - tempz);
            if (tempz < 60)
            {
                low_milage.Text = "Low mileage";
            }

            
            name.Text = details[0];
            model.Text = details[1];
            car_no.Text = details[2];
            time.Text = details[3];
            fuel.Text = details[4];
            milage.Text = details[5];
            cost.Text = details[6];

        }
    }
}