using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MicCheck.Mobile
{
    public partial class MainPage : ContentPage
    {
        private static string _baseViewUrl = "http://10.0.2.2:13601/";
        private WebView _webview;

        public MainPage()
        {
            InitializeComponent();

            Debug.WriteLine("MainPage.Ctor -> started...");

            _webview = new WebView()
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Source = _baseViewUrl
            };

            Content = _webview;

            Debug.WriteLine("MainPage.Ctor -> completed");
        }

        protected override bool OnBackButtonPressed()
        {
            Debug.WriteLine("MainPage.OnBackButtonPressed -> started...");
            _webview.GoBack();
            Debug.WriteLine("MainPage.OnBackButtonPressed -> finished");
            return true;
        }
    }
}
