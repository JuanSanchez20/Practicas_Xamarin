using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Info_Lenguajes
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void btnPython_Clicked(object sender, EventArgs e)
        {
            // Lógica para el botón btnLeerMas
            Browser.OpenAsync("https://docs.python.org/");
        }
        private void btnJava_Clicked(object sender, EventArgs e)
        {
            // Lógica para el botón btnLeerMas
            Browser.OpenAsync("https://docs.oracle.com/en/java/");
        }
        private void btnCSharp_Clicked(object sender, EventArgs e)
        {
            // Lógica para el botón btnLeerMas1
            Browser.OpenAsync("https://developer.mozilla.org/es/docs/Web/JavaScript");
        }
        private void btnAndroid_Clicked(object sender, EventArgs e)
        {
            // Lógica para el botón btnLeerMas2
            Browser.OpenAsync("https://learn.microsoft.com/en-us/dotnet/csharp/");
        }
        private void btniOS_Clicked(object sender, EventArgs e)
        {
            // Lógica para el botón btnLeerMas3
            DisplayAlert("Leer Más", "Información adicional sobre Swift.", "OK");
        }
        private void btnXamarin_Clicked(object sender, EventArgs e)
        {
            // Lógica para el botón btnLeerMas4
            DisplayAlert("Leer Más", "Información adicional sobre Xamarin.", "OK");
        }
        public void OnGitHubButtonClicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://github.com/JuanSanchez20/Practicas_Xamarin");
        }
    }
}
