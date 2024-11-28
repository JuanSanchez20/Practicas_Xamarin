using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Plugin.Media;
using Plugin.Media.Abstractions;

namespace Hamburger
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageB : ContentPage
    {
        public PageB()
        {
            InitializeComponent();
        }
        // Evento para seleccionar la imagen
        private async void OnSelectImageClicked(object sender, EventArgs e)
        {
            var media = CrossMedia.Current;

            if (!media.IsPickPhotoSupported)
            {
                await DisplayAlert("Error", "Seleccionar imágenes no es soportado en este dispositivo", "OK");
                return;
            }

            var selectedImage = await media.PickPhotoAsync(new PickMediaOptions
            {
                PhotoSize = PhotoSize.Medium
            });

            if (selectedImage != null)
            {
                // Establece la imagen seleccionada en el control Image
                userImage.Source = ImageSource.FromStream(() => selectedImage.GetStream());
            }
        }

        // Evento para registrar el usuario
        private void OnRegisterUserClicked(object sender, EventArgs e)
        {
            // Lógica para registrar al usuario (validar campos, guardar, etc.)
            DisplayAlert("Usuario Registrado", "El usuario ha sido registrado correctamente.", "OK");
        }
    }
}