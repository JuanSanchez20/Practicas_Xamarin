using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CedulaValidation
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnValidarClicked(object sender, EventArgs e)
        {
            string cedula = CedulaEntry.Text;

            if (string.IsNullOrEmpty(cedula) || !EsCedulaValida(cedula))
            {
                ResultadoLabel.TextColor = Color.Red;
                ResultadoLabel.Text = "Cédula inválida.";
            }
            else
            {
                ResultadoLabel.TextColor = Color.Green;
                ResultadoLabel.Text = "Cédula válida.";
            }
        }

        private bool EsCedulaValida(string cedula)
        {
            if (cedula.Length != 10 || !int.TryParse(cedula, out _)) return false;

            int provincia = int.Parse(cedula.Substring(0, 2));
            if (provincia < 1 || (provincia > 24 && provincia != 30)) return false;

            int[] coeficientes = { 2, 1, 2, 1, 2, 1, 2, 1, 2 };
            int suma = 0;

            for (int i = 0; i < 9; i++)
            {
                int valor = (cedula[i] - '0') * coeficientes[i];
                suma += valor > 9 ? valor - 9 : valor;
            }

            int verificador = (10 - (suma % 10)) % 10;
            return verificador == (cedula[9] - '0');
        }
    }
}
