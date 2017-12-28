using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace coralApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            webView.Source = "https://www.facebook.com/coraljovemnh/";
        }

        private void WebViewNavigated(object sender, WebNavigatedEventArgs e)
        {
            activityIndicator.IsVisible = false;
            activityIndicator.IsRunning = false;
        }
    }
}
