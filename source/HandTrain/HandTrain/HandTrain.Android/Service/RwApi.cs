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

namespace HandTrain.Droid.Service
{
    class RwApi
    {
        private string templateStringRequest = "http://rasp.rw.by/ru/route/?from={0}&from_exp=0&from_esr=0&to={1}&to_exp=0&to_esr=0&date={2}";
    }
}