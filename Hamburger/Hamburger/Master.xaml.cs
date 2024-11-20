using Hamburger;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hamburger
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : ContentPage
    {
        public Master()
        {
            InitializeComponent();
            var masterPageItems = new List<MasterPageItem>
            {
                new MasterPageItem
                {
                    Title = "PA",
                    IconSource = "icon.png",
                    TargetType = typeof(PageA)
                },
                new MasterPageItem
                {
                    Title = "PB",
                    IconSource = "icon.png",
                    TargetType = typeof(PageB)
                },
                new MasterPageItem
                {
                    Title = "Salir",
                    IconSource = "icon_exit.png", // Opcional, si tienes un ícono para salir
                    Action = async () =>
                    {
                        // Lógica de salida, como cerrar la sesión o salir de la app
                        var result = await Application.Current.MainPage.DisplayAlert("Confirmar", "¿Estás seguro de que deseas salir?", "Sí", "No");
                        if (result)
                        {
                            // Aquí puedes manejar la lógica para cerrar la aplicación, por ejemplo:
                            System.Diagnostics.Process.GetCurrentProcess().Kill(); // Mata el proceso de la app
                        }
                    }
                }
            };
            listView.ItemsSource = masterPageItems;
        }

        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                if (item.TargetType != null)
                {
                    // Si el TargetType no es nulo, navega a la página
                    App.MasterDetail.Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                }
                else if (item.Action != null)
                {
                    // Si hay una acción (como en el caso de "Salir"), ejecuta la acción
                    item.Action.Invoke();
                }

                // Limpia la selección y cierra el menú hamburguesa
                listView.SelectedItem = null;
                App.MasterDetail.IsPresented = false;
            }
        }

    }
}
