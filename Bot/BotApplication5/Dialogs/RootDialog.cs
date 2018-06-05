using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using BotApplication5;
using Newtonsoft.Json;

namespace BotApplication5.Dialogs
{
    [Serializable]
    public class RootDialog : IDialog<object>
    {
        string a = "";
        //string token = "OAuth 0_w1S05y9UtRqcKko0yshozoi78=";
        string rep = "";
        List<string> Reports = new List<string>();
        bool ret = false;

        private void DeleteFromList(int num) //index of the report in the list
        {
            Reports.RemoveAt(num);

        }

        private string PrintReport()
        {
            string l = "\n";
            for (int i = 0; i < Reports.Count; i++)
            {
                l = l + (i + 1).ToString() + ")" + Reports[i] + "\n";

            }
            return l;
        }

        private static string ReadStreamFromResponse(WebResponse response)
        {
            using (Stream responseStream = response.GetResponseStream())
            using (StreamReader sr = new StreamReader(responseStream))
            {
                //Need to return this response 
                string strContent = sr.ReadLine();
                return strContent;

            }
        }

        private string ExtractReport(string json)
        {
            string rep = "";
            if (!String.IsNullOrEmpty(json))
            {
                var list = JsonConvert.DeserializeObject<List<Vehicle>>(json);
                for (int i = 0; i < list.Count; i++)
                {
                    Reports.Add(list[i].Vehicle_No);
                    string s = (i + 1).ToString() + ")";
                    rep = rep + "\n" + s + list[i].Vehicle_No;
                };

            }
            else
            {
                rep = "No Vehicles to Display";
            }
            return rep;

        }
        public Task StartAsync(IDialogContext context)
        {
            context.Wait(MessageReceivedAsync);

            return Task.CompletedTask;
        }

        private async Task MessageReceivedAsync(IDialogContext context, IAwaitable<object> result)
        {
            var activity = await result as Activity;
            //Reports.Clear();
            // Calculate something for us to return
            string strActivityText = activity.Text;
            strActivityText = strActivityText.Replace(".", "").ToLower();
            if (activity.Text != string.Empty)
            {

                //if (strActivityText == "travel app" || strActivityText=="Travel App" || strActivityText=="TRAVEL APP" || strActivityText=="Travel app" || strActivityText.Contains("Travel app"))
                if (strActivityText.Contains("mileage app"))
                {
                    rep = callapi();
                    ret = true;
                    //Result(context,rep,true);

                }
                else
                {
                    int i = 0;
                    if (strActivityText.Contains("delet"))
                    {
                        strActivityText = strActivityText.Substring(strActivityText.IndexOf("delet"));
                    }
                    string[] t = strActivityText.Replace(".", "").Split();

                    //if(t[0] == "approve" || t[0] == "Approve" || t[0]=="approved" || t[0]=="Approved")
                    if (t[0].Contains("delet"))
                    {
                        if (Reports.Count == 0 && ret == false)
                        {
                            rep = "Sorry.. Retrive the reports first, you can use \"Travel App\" for the same";
                            //Result(context,rep,true);
                        }
                        else
                        {
                            if (t[1].Length == 1)
                            {

                                i = (int)t[1][0] - 49;
                            }


                            else
                            {
                                i = convertToDigit(strActivityText) - 1;
                            }
                        }


                        if (i < Reports.Count)
                        {
                            var Url = "http://localhost:3033/api/values/"+Reports[i];

                            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(Url);
                            request.Method = "DELETE";
                            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                            rep = "Deleting " + Reports[i];


                                //Result(context, rep, true);

                                DeleteFromList(i);
                                rep = rep + "\n\n" + PrintReport();
                            
                            //Result(context, rep, false);
                           

                        }
                        else
                        {
                            if (Reports.Count == 0 && ret == true)
                            {
                                rep = "All reports are deleted";
                                //Result(context, rep, true);
                            }
                            else
                            {
                                if (ret == true)
                                {
                                    rep = "This report cannot be deleted";
                                    //Result(context, rep, true);
                                    rep = rep + "\n\n" + PrintReport();
                                    //Result(context, rep, false);
                                }
                            }
                        }



                    }
                    else
                    {
                        rep = "Not able to execute the operation";
                        //Result(context, rep, true);
                        rep = rep + "\n\n" + PrintReport();
                        //Result(context, rep, false);
                    }

                }

            }



            //int length = (activity.Text ?? string.Empty).Length;

            // Return our reply to the user


            await context.SayAsync(text: rep, speak: rep);
            //Activity reply = activity.CreateReply(rep);
            //reply.Speak = rep;
            //reply.InputHint = InputHints.ExpectingInput;

            context.Wait(MessageReceivedAsync);
        }

        private string callapi()
        {
            Reports.Clear();
            var Url = "http://localhost:3033/api/values/";


            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(Url);
            request.Method = "GET";
            //request.Headers["Authorization"] = token;
            request.ContentType = "application/json";
            WebResponse response = request.GetResponse();
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                a = reader.ReadToEnd();
            }
            string rep = ExtractReport(a);

            return rep;
        }

        private int convertToDigit(string text)
        {
            int r = 0;
            string[] tokens = text.Split();
            if (tokens.Length == 2)
            {
                if (tokens[1] == "one")
                    r = 1;
                if (tokens[1] == "two")
                    r = 2;
                if (tokens[1] == "three")
                    r = 3;
                if (tokens[1] == "four")
                    r = 4;
                if (tokens[1] == "five")
                    r = 5;
                if (tokens[1] == "six")
                    r = 6;
                if (tokens[1] == "seven")
                    r = 7;
                if (tokens[1] == "eight")
                    r = 8;
                if (tokens[1] == "nine")
                    r = 9;
                if (tokens[1] == "ten")
                    r = 10;
                if (tokens[0] == "eleven")
                    r = 11;
                if (tokens[1] == "twelve")
                    r = 12;
                if (tokens[1] == "thirteen")
                    r = 13;
                if (tokens[1] == "fourteen")
                    r = 14;
                if (tokens[1] == "fifteen")
                    r = 15;
                if (tokens[1] == "sixteen")
                    r = 16;
                if (tokens[1] == "seventeen")
                    r = 17;
                if (tokens[1] == "eighteen")
                    r = 18;
                if (tokens[1] == "nineteen")
                    r = 19;
                if (tokens[1] == "twenty")
                    r = 20;


            }
            else if (tokens.Length == 3)
            {

            }
            else
            {

            }
            return r;
        }


    }
}