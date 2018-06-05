using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace Client1
{
    public partial class MainDashboard : System.Web.UI.Page
    {
        public List<Control> otilia = new List<Control>();
        public List<CheckBox> cotilia = new List<CheckBox>();
        public List<Vehicle> l = new List<Vehicle>();
        string result = "";
       
         
        public List<Vehicle> get_values()
        {

            var Url = "http://localhost:3033/api/values/";
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(Url);
            request.Method = "GET";
            var httpResponse = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }
            var list = JsonConvert.DeserializeObject<List<Vehicle>>(result);
            return list;



        }
        protected void Page_Load(object sender, EventArgs e)
        {
            var l=get_values();      
            
            //doodler1.Visible = true;
            for (int i = 0; i < l.Count; i++)  //foreach
            {
                Control ctrl = Page.LoadControl("~/doooodler.ascx");
                ctrl.ID = l[i].Vehicle_No; // vehicle-no
                Panel1.Controls.Add(ctrl);

                Control ctrl1 = Page.LoadControl("~/chaaarts.ascx");
                otilia.Add(ctrl1);
                ctrl1.ID = l[i].Vehicle_No+"_2"; //vehicle-no
                Panel1.Controls.Add(ctrl1);

                CheckBox ch = new CheckBox();
                cotilia.Add(ch);
                ch.ID = "ch_" + l[i].Vehicle_No;
                ch.Text = "show Details for" + l[i].Vehicle_No;
                Panel1.Controls.Add(ch);
            }
                        foreach (Control c in otilia)
            {
                c.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
    int i = 0;
    foreach (Control c in otilia)
    {
        otilia[i].Visible = cotilia[i].Checked;
        i++;
    }
}
    }
}