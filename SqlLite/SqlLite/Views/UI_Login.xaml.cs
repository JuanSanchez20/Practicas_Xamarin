using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SqlLite.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UI_Login : ContentPage
    {
        public UI_Login()
        {
            InitializeComponent();
        }
        public void btn_Registrar(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UI_Registro());
        }
        public void btn_Login(object sender, EventArgs e)
        {
            
        }
    }
}