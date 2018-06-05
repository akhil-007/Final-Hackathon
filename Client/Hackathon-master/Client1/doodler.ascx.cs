using Client1;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class doodler : System.Web.UI.UserControl
{
    public Transaction get_data_transaction(string ID)
    {
        var result="";
        var Url = "http://localhost:3033/api/transaction/"+ID;
        HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(Url);
        request.Method = "GET";
        var httpResponse = (HttpWebResponse)request.GetResponse();
        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
        {
            result = streamReader.ReadToEnd();
        }
        var list = JsonConvert.DeserializeObject<Transaction> (result);
        return list;
    }

    public Vehicle get_data_master(string ID)
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
        return list;

    }
 

    protected void Chart1_Load(object sender, EventArgs e)
    {
      
    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        var t= get_data_transaction(this.ID);
        var p = get_data_master(this.ID);
        


        

    }
}