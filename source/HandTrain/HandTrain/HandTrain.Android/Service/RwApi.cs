using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using HandTrain.Droid.Models;

namespace HandTrain.Droid.Service
{
    class RwApi
    {
        private readonly string templateStringRequest = "http://rasp.rw.by/ru/route/?from={0}&from_exp=0&from_esr=0&to={1}&to_exp=0&to_esr=0&date={2}";

        public List<Route> GetRoutesByRequest(string fromCity, string toCity, string date)
        {
            string urlAddress = string.Format(templateStringRequest, fromCity, toCity, date);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlAddress);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string htmlData = GetHtmlByRequest(response);
            var a = ParserRw.ParseHtml(htmlData);


            return null;
        }

        private string GetHtmlByRequest(HttpWebResponse response)
        {
            string data = String.Empty;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream;

                if (response.CharacterSet == null)
                {
                    readStream = new StreamReader(receiveStream ?? throw new InvalidOperationException());
                }
                else
                {
                    readStream = new StreamReader(receiveStream ?? throw new InvalidOperationException(), Encoding.GetEncoding(response.CharacterSet));
                }

                data = readStream.ReadToEnd();

                response.Close();
                readStream.Close();
            }
            return data;
        }
    }
}