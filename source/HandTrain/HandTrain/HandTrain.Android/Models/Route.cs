using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace HandTrain.Droid.Models
{
    class Route
    {
        public string FirstCity { get; set; }
        public string SecondCity { get; set; }
        public string NameOfRoute { get; set; }
        public string DataTime { get; set; }
        public string ArrivalTime { get; set; }
        public string DepartureЕime{ get; set; }
        public string TimeToWay { get; set; }
        public string Price { get; set; }
        public string AvalibleTickets { get; set; }
    }
}