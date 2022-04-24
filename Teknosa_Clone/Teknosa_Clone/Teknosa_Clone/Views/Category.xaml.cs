using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Teknosa_Clone.Models;

namespace Teknosa_Clone.Views
{
    public partial class Category : ContentPage
    {
        ObservableCollection<Products> obProducts;
        public Category()
        {
            InitializeComponent();
            AddProducts();
            lstProducts.ItemsSource = obProducts;
        }

        public void AddProducts()
        {
            try
            {
                obProducts = new ObservableCollection<Products>();
                obProducts.Add(new Products
                {
                    productImage = "https://images-na.ssl-images-amazon.com/images/I/813y2%2BdPUOL._AC_SL1500_.jpg",
                    productName = "Category2",
                });

                obProducts.Add(new Products
                {
                    productImage = "https://m.media-amazon.com/images/I/71sNNCTfMuL._FMwebp__.jpg",
                    productName = "Bilgisayar ve Tablet",
                });

                obProducts.Add(new Products
                {
                    productImage = "https://images-na.ssl-images-amazon.com/images/I/61v0enHOXpL._AC_SL1500_.jpg",
                    productName = "Televizyon, Ses ve Görüntü Sistemleri",
                });

                obProducts.Add(new Products
                {
                    productImage = "https://images-na.ssl-images-amazon.com/images/I/71MHTD3uL4L._SL1500_.jpg",
                    productName = "Beyaz Eşya ve Ankastre",
                });

                obProducts.Add(new Products
                {
                    productImage = "https://images-na.ssl-images-amazon.com/images/I/71OYLm6srFL._SL1500_.jpg",
                    productName = "Elektrikli Ev Aletleri",
                });

                obProducts.Add(new Products
                {
                    productImage = "https://images-na.ssl-images-amazon.com/images/I/813y2%2BdPUOL._AC_SL1500_.jpg",
                    productName = "Kişisel Bakım",
                });

                obProducts.Add(new Products
                {
                    productImage = "https://images-na.ssl-images-amazon.com/images/I/813y2%2BdPUOL._AC_SL1500_.jpg",
                    productName = "Konsol, Oyun ve Oyuncu Ekipmanları",
                });

                obProducts.Add(new Products
                {
                    productImage = "https://images-na.ssl-images-amazon.com/images/I/410mmBW-AYL._AC_.jpg",
                    productName = "Fotoğtaf Makinesi ve Kamera",
                });

                obProducts.Add(new Products
                {
                    productImage = "https://images-na.ssl-images-amazon.com/images/I/71valQo5u5L._AC_SL1500_.jpg",
                    productName = "Ev ve Yaşam",
                });

                obProducts.Add(new Products
                {
                    productImage = "https://images-na.ssl-images-amazon.com/images/I/61sLvszoETL._AC_SL1500_.jpg",
                    productName = "Ofis Malzemeleri ve Mobilyaları",
                });

                obProducts.Add(new Products
                {
                    productImage = "https://www.chip.com.tr/images/content/2021/03/18/20210318130429941119.jpg",
                    productName = "Müzik Enstürman ve Ekipmanı",
                });
            }
            catch (Exception ex)
            {

            }
        }

        //private async void LstProducts_ItemTapped(object sender, ItemTappedEventArgs e)
        //{
        //    try
        //    {

        //        await DisplayAlert("You selected", selectedProduct.productName, "Buy", "Cancel");

        //    }
        //    catch (Exception ex)
        //    {
        //        await DisplayAlert("Error", ex.Message.ToString(), "Ok");
        //    }
        //    lstProducts.SelectedItem = null;
        //}

        // Dediğim kısım
        private async void TapGestureRecognizer_Tapped(Object sender, ItemTappedEventArgs e)
        {
            var selectedProduct = (Products)e.Item;


            await Navigation.PushAsync(new Category2());
        }
    }
}