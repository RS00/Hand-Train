using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandTrain.Droid.Service;
using Xamarin.Forms;

namespace HandTrain
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

	    private void Button_OnClicked(object sender, EventArgs e)
	    {
	        var rw = new RwApi();
	        rw.GetRoutesByRequest("Жлобин", "Минск", "2017-12-20");
	    }
	}
}
