using GeolocationApp;
using Geologia_2._0.Services;
using Geologia_2._0.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Geologia_2._0
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            // Establece la página principal como la que creaste
            MainPage = new NavigationPage(new GeolocationPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
