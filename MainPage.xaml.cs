using System;
using System.Windows;
using Microsoft.Phone.Controls;

namespace SeaGateQVM
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();
            Browser.LoadCompleted += Browser_LoadCompleted;
            Browser.Navigate(new Uri("html/SeaGateQVM.html", UriKind.Relative));
        }

        private void Browser_LoadCompleted(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            // HTML/JavaScript is intentionally kept inside the WebBrowser control.
        }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            // Prevent accidental exit while the HTML application is running.
            e.Cancel = true;
        }
    }
}
