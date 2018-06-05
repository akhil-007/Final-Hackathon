using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace Client1
{
    public class HCMileage
    {
        public List<double> calling(string id,string type,Double known_mileage) //the one for query 
        {
            var result = "";
            var Url = "http://localhost:3033/api/transaction?id=" + id + "&type=" + type;
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
                var list1 = list[0];
                if (type == "city")
                {
                    findmilage(known_mileage, list1.Mileage);


                }
                else
                {
                    findmilage(list1.Mileage, known_mileage);
                }
            }
            else
            {
                if(type=="city")
                {
                    findmilage(known_mileage, 0);
                }
                else
                {
                    findmilage(0, known_mileage);
                }
            }

            List<double> l = new List<double>();
            l.Add(CMilage);
            l.Add(OMilage);
            return l;

        }
        public double CMilage, OMilage;
        public void  findmilage(double CRMilage, double ORMilage)
        {

            //change 0.8,0.2 to change the urban:out ratio
            double a = 0.8, b = 0.2, d = 0.2, e = 0.8, x = 1, y = 1;
            // difference between outstation vs urban milage - urbanmilage * dif = outmilage
            double dif = 1.3;
            if (CRMilage > 0 && ORMilage > 0)
            {

                double c = 1 / CRMilage, f = 1 / ORMilage;

                x = ((c * e) - (f * b)) / ((a * e) - (b * d));
                y = ((a * f) - (c * d)) / ((a * e) - (b * d));


            }
            else if (CRMilage <= 0)
            {
                double f = 1 / ORMilage;

                y = f / ((d * dif) + e);
                x = y * dif;

            }
            else if (ORMilage <= 0)
            {
                double c = 1 / CRMilage;

                y = c / ((a * dif) + b);
                x = y * dif;
            }

            CMilage = 1 / x;
            OMilage = 1 / y;

            

        }
        //FROM DB-  Urban ride avg milage (cityT) = avarage milage of urban rides
        //FROM DB-  Outstation ride avg milage(outT) = avarage milage of Outstation rides

        //ANS-  Urban milage(cityM) = required urban milage
        //ANS-  Outstation milage(outM) = required outstation milage

        
       
    }
}