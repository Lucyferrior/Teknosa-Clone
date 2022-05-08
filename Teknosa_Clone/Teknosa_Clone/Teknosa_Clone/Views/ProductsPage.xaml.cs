using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Teknosa_Clone.Services;
using Teknosa_Clone.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Teknosa_Clone.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class ProductsPage : ContentPage
    {
        public ProductsPage ()
        {
            InitializeComponent();
            BindingContext = new FavoritePageViewModel();
        }

    

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var selectedProduct = (ItemDataStore)e.Item;
            
            await Navigation.PushAsync(new MainPage());



        }
    }
}

