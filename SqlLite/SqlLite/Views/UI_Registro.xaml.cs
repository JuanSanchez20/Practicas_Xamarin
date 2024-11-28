using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
// Conexion
using SqlLite.Tables;

namespace SqlLite.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UI_Registro : ContentPage
    {
        private SQLiteAsyncConnection _conn;
        public UI_Registro()
        {
            InitializeComponent();
            _conn = DependencyService.Get<ISQLite>().GetConnection();
        }
        public void btn_Agregar(object sender, EventArgs e)
        {
            var registerData = new T_Registro { Name = Nombre.Text, User = Usuario.Text, Password = Contraseña.Text };
            // Inngresar los datos
            _conn.InsertAsync(registerData);
            limpiarFormulario();
        }
        void limpiarFormulario()
        {
            Nombre.Text = "";
            Usuario.Text = "";
            Contraseña.Text = "";
        }
    }
}