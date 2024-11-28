using SqlLite.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SqlLite
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new UI_Registro();
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
