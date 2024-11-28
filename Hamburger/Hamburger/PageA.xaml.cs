using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Xamarin.Essentials;
using System.IO;

namespace Hamburger
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageA : ContentPage
    {
        public PageA()
        {
            InitializeComponent();
        }
        public async void OnSelectImageClicked(object sender, EventArgs e)
        {
            try
            {
                // Abre la galería para seleccionar una imagen
                var result = await MediaPicker.PickPhotoAsync(new MediaPickerOptions
                {
                    Title = "Selecciona una imagen"
                });

                // Si el usuario seleccionó una imagen
                if (result != null)
                {
                    // Lee la imagen seleccionada y la convierte en un stream
                    var stream = await result.OpenReadAsync();

                    // Muestra la imagen en el control Image
                    productImage.Source = ImageSource.FromStream(() => stream);
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores, por ejemplo, si el usuario cancela la selección
                await DisplayAlert("Error", "No se pudo seleccionar la imagen: " + ex.Message, "OK");
            }
        }
        public void OnRegisterProductClicked(object sender, EventArgs e)
        {

        }
    }
}