using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Teknosa_Clone.Models;

namespace Teknosa_Clone.Views
{
    public partial class CategoryPage : ContentPage
    {
        ObservableCollection<Category> obProducts;
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
                obProducts = new ObservableCollection<Category>();
                obProducts.Add(new Category
                {
                    ImageSource = "https://images-na.ssl-images-amazon.com/images/I/813y2%2BdPUOL._AC_SL1500_.jpg",
                    Name = "Telefon",
                    Id = "1"
                });

                obProducts.Add(new Category
                {
                    ImageSource = "https://reimg-teknosa-cloud-prod.mncdn.com/mnresize/600/600/productimage/786280522/786280522_3_MC/e151bf2e72e7478d9ed32162b2259802.jpg",
                    Name = "Bilgisayar ve Tablet",
                    Id = "2"
                });

                obProducts.Add(new Category
                {
                    ImageSource = "https://reimg-teknosa-cloud-prod.mncdn.com/mnresize/600/600/productimage/110016598/110016598_0_MC/52694612.jpg",
                    Name = "Televizyon, Ses ve Görüntü Sistemleri",
                    Id = "3"
                });

                obProducts.Add(new Category
                {
                    ImageSource = "https://reimg-teknosa-cloud-prod.mncdn.com/mnresize/600/600/productimage/781870048/781870048_0_MC/4a7a46d0236f411597c4c879a58989c7.jpg",
                    Name = "Beyaz Eşya ve Ankastre",
                    Id = "4"
                });

                obProducts.Add(new Category
                {
                    ImageSource = "https://reimg-teknosa-cloud-prod.mncdn.com/mnresize/600/600/productimage/115043362/115043362_0_MC/27510863.jpg",
                    Name = "Elektrikli Ev Aletleri",
                    Id = "5"
                });

                obProducts.Add(new Category
                {
                    ImageSource = "https://reimg-teknosa-cloud-prod.mncdn.com/mnresize/600/600/productimage/787870081/787870081_0_MC/62159053.jpg",
                    Name = "Kişisel Bakım",
                    Id = "6"
                });

                obProducts.Add(new Category
                {
                    ImageSource = "https://img-teknosa-sap.mncdn.com/nav/konsol_210110.jpg",
                    Name = "Konsol, Oyun ve Oyuncu Ekipmanları",
                    Id = "7"
                });

                obProducts.Add(new Category
                {
                    ImageSource = "https://img-teknosa-sap.mncdn.com/nav/fotograf_makinesi_210110.jpg",
                    Name = "Fotoğtaf Makinesi ve Kamera",
                    Id = "8"
                });

                obProducts.Add(new Category
                {
                    ImageSource = "https://m.media-amazon.com/images/I/61sUTvBI1ZL._AC_SL1001_.jpg",
                    Name = "Ev ve Yaşam",
                    Id = "9"
                });

                obProducts.Add(new Category
                {
                    ImageSource = "https://img-teknosa-sap.mncdn.com/nav/ofis_mobilyalari_210110.jpg",
                    Name = "Ofis Malzemeleri ve Mobilyaları",
                    Id = "10"
                });

                obProducts.Add(new Category
                {
                    ImageSource = "https://m.media-amazon.com/images/I/41m7Bb8Wa-L._AC_SL1024_.jpg",
                    Name = "Müzik Enstürman ve Ekipmanı",
                    Id = "11"
                });
            }
            catch (Exception ex)
            {

            }
        }



        private async void TapGestureRecognizer_Tapped(Object sender, ItemTappedEventArgs e)
        {
            var selectedProduct = (Category)e.Item;

            await Navigation.PushAsync(new CategoryPage4(selectedProduct.Id));
        }
    }
}