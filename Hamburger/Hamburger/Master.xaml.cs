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
                }
            };

            listView.ItemsSource = masterPageItems;
        }

        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                // Navegar a la página seleccionada
                App.MasterDetail.Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                listView.SelectedItem = null;
                App.MasterDetail.IsPresented = false;
            }
        }
    }
}
