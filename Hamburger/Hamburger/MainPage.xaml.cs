using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hamburger
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            Master = new Master();
            Detail = new NavigationPage(new Detail())
            {
                BarBackgroundColor = Color.Black,
                BarTextColor = Color.White
            };

            App.MasterDetail = this;
        }
    }
}
