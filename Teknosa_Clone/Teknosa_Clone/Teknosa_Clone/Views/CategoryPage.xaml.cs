using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Teknosa_Clone.Models;

namespace Teknosa_Clone.Views
{
    public partial class CategoryPage : ContentPage
    {
        ObservableCollection<Products> obProducts;
        public CategoryPage()
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
                    productName = "Telefon",
                    productId = 1
                });

                obProducts.Add(new Products
                {
                    productImage = "https://reimg-teknosa-cloud-prod.mncdn.com/mnresize/600/600/productimage/786280522/786280522_3_MC/e151bf2e72e7478d9ed32162b2259802.jpg",
                    productName = "Bilgisayar ve Tablet",
                    productId = 2
                });

                obProducts.Add(new Products
                {
                    productImage = "https://reimg-teknosa-cloud-prod.mncdn.com/mnresize/600/600/productimage/110016598/110016598_0_MC/52694612.jpg",
                    productName = "Televizyon, Ses ve Görüntü Sistemleri",
                    productId = 3
                });

                obProducts.Add(new Products
                {
                    productImage = "https://reimg-teknosa-cloud-prod.mncdn.com/mnresize/600/600/productimage/781870048/781870048_0_MC/4a7a46d0236f411597c4c879a58989c7.jpg",
                    productName = "Beyaz Eşya ve Ankastre",
                    productId = 4
                });

                obProducts.Add(new Products
                {
                    productImage = "https://reimg-teknosa-cloud-prod.mncdn.com/mnresize/600/600/productimage/115043362/115043362_0_MC/27510863.jpg",
                    productName = "Elektrikli Ev Aletleri",
                    productId = 5
                });

                obProducts.Add(new Products
                {
                    productImage = "https://reimg-teknosa-cloud-prod.mncdn.com/mnresize/600/600/productimage/787870081/787870081_0_MC/62159053.jpg",
                    productName = "Kişisel Bakım",
                    productId = 6
                });

                obProducts.Add(new Products
                {
                    productImage = "https://img-teknosa-sap.mncdn.com/nav/konsol_210110.jpg",
                    productName = "Konsol, Oyun ve Oyuncu Ekipmanları",
                    productId = 7
                });

                obProducts.Add(new Products
                {
                    productImage = "https://img-teknosa-sap.mncdn.com/nav/fotograf_makinesi_210110.jpg",
                    productName = "Fotoğtaf Makinesi ve Kamera",
                    productId = 8
                });

                obProducts.Add(new Products
                {
                    productImage = "https://m.media-amazon.com/images/I/61sUTvBI1ZL._AC_SL1001_.jpg",
                    productName = "Ev ve Yaşam",
                    productId = 9
                });

                obProducts.Add(new Products
                {
                    productImage = "https://img-teknosa-sap.mncdn.com/nav/ofis_mobilyalari_210110.jpg",
                    productName = "Ofis Malzemeleri ve Mobilyaları",
                    productId = 10
                });

                obProducts.Add(new Products
                {
                    productImage = "https://m.media-amazon.com/images/I/41m7Bb8Wa-L._AC_SL1024_.jpg",
                    productName = "Müzik Enstürman ve Ekipmanı",
                    productId = 11
                });
            }
            catch (Exception ex)
            {

            }
        }



        private async void TapGestureRecognizer_Tapped(Object sender, ItemTappedEventArgs e)
        {
            var selectedProduct = (Products)e.Item;

            await Navigation.PushAsync(new CategoryPage4(selectedProduct.productId));
        }
    }
}