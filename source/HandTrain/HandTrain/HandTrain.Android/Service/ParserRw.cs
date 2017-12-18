using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Views;
using Android.Widget;
using HandTrain.Droid.Models;
using HtmlAgilityPack;
using Javax.Crypto.Interfaces;

namespace HandTrain.Droid.Service
{
    class ParserRw
    {
        public static List<Route> ParseHtml(string html)
        {
            HtmlDocument htmlSnippet = new HtmlDocument();
            htmlSnippet.LoadHtml(html);

            var a = htmlSnippet.DocumentNode.Descendants("tr")
                .Select(y => y.Descendants()
                    .Where(x => x.Attributes["class"].Value == "w_places"))
                .ToList();
            

            return null;
        }

    }
}