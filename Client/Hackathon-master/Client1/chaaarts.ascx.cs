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
    public partial class chaaarts : System.Web.UI.UserControl
    {
        string[] details=new string[11];//= { "0000", "Outstation", "85", "25", "8", "8", "1600", "Chennai", "06:00", "Banglore", "16:00" };
        

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
            
            var list1 = JsonConvert.DeserializeObject<List<Transaction>>(result);
            if (list1.Count != 0)
            {
                var list = list1[0];
               

                details[0] = list.Trip_Id.ToString();
                details[1] = list.Ride_Type;
                details[2] = list.Distance.ToString();
                details[3] = list.Fuel.ToString();
                details[4] = list.Mileage.ToString();
                details[5] = (list.Fuel_Cost_Litre*list.Distance).ToString();
                details[6] = list.Start_Date.ToString();
                details[7] = list.End_Date.ToString();
            }
            else
            {
                for(int i=0;i<details.Length;i++)
                {
                    details[i] = "";
                }
            }


        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
            string number = this.ID.Substring(0, this.ID.Length - 2);
            get_data_transaction(number);


            if (details[0] != "")
            {
                HCMileage obj = new HCMileage();
                List<double> a=new List<double>();
                if (details[1] == "city")
                {
                     a = obj.calling(number, "oustation", Double.Parse(details[4]));
                }
                else
                {
                     a= obj.calling(number, "city", Double.Parse(details[4]));
                }

                Chart1.Series[0].Points.AddXY("KMpL", a[0]);
                Chart1.Series[1].Points.AddXY("", a[1]);
            }


            if(details[0]=="")
            {
                Label1.Visible = true;
            }


            //details[0] = number;
            id.Text = details[0];
            trip_type.Text = details[1];
            Distence.Text = details[2];
            fuel.Text = details[3];
            milage.Text = details[4];
            cost.Text = details[5];
            s_location.Text = details[6];
            //s_time.Text = details[7];
            e_location.Text = details[8];
            //e_time.Text = details[9];
        }
    }
}