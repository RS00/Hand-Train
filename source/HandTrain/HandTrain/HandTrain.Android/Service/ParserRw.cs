using System.Collections.Generic;
using System.Linq;
using HandTrain.Droid.Models;
using HtmlAgilityPack;

namespace HandTrain.Droid.Service
{
    class ParserRw
    {
        public static List<Route> ParseHtml(string html)
        {
            HtmlDocument htmlSnippet = new HtmlDocument();
            htmlSnippet.LoadHtml(html);
            var routes = new List<Route>();
            var routeHtmlelements = htmlSnippet.DocumentNode.Descendants("tr").ToList();
            if(routeHtmlelements != null)
            {
                routeHtmlelements.Remove(routeHtmlelements[0]);
                foreach (var item in routeHtmlelements)
                {
                    routes.Add(new Route
                    {
                        NameOfRoute = item.ChildNodes.Descendants(".train_name > a").ToString(),
                        ArrivalTime = item.ChildNodes.Descendants(".train_start-time").ToString(),
                        DepartureЕime = item.ChildNodes.Descendants(".train_end-time").ToString(),
                        TimeToWay = item.ChildNodes.Descendants(".train_time-total").ToString(),
                        Price = item.ChildNodes.Descendants(".denom_after").ToString(),
                        AvalibleTickets = item.ChildNodes.Descendants(".train_place > a").ToString()
                    });
                }
            }
            else
            {
                return null;
            }
            
            return routes;
        }

    }
}