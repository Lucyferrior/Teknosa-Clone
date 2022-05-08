using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Teknosa_Clone.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Teknosa_Clone.Views
{
    public partial class AccountPage : ContentPage
    {
        ObservableCollection<Category> obProducts;


        public AccountPage()
        {
            InitializeComponent();

            AddProducts();

            lstProducts.ItemsSource = obProducts;
        }

       
        public void AddProducts()
        {
            obProducts = new ObservableCollection<Category>();
            obProducts.Add(new Category
            {
                Name = "Siparişlerim",
                ImageSource = "https://img.icons8.com/ios/344/shopping-cart.png"
            });


            obProducts.Add(new Category
            {
                Name = "Favorilerim",
                ImageSource = "https://img.icons8.com/ios/344/bookmark-ribbon--v1.png"
            });

            obProducts.Add(new Category
            {
                Name = "Satıcı Sorularım",
                ImageSource = "https://img.icons8.com/ios/344/ask-question.png"
            });
            obProducts.Add(new Category
            {
                Name = "Adreslerim",
                ImageSource = "https://img.icons8.com/ios/344/marker--v1.png"
            });
            obProducts.Add(new Category
            {
                Name = "Kayıtlı Kartlarım",
                ImageSource = "https://img.icons8.com/ios/344/bank-card-back-side.png"
            });
            obProducts.Add(new Category
            {
                Name = "Üyelik Bilgilerim",
                ImageSource = "https://img.icons8.com/external-dreamstale-lineal-dreamstale/344/external-user-ui-dreamstale-lineal-dreamstale.png"
            });
            obProducts.Add(new Category
            {
                Name = "İletişim İzinlerim",
                ImageSource = "https://img.icons8.com/small/344/ok--v1.png"
            });
            obProducts.Add(new Category
            {
                Name = "Şifre Değiştirme",
                ImageSource = "https://img.icons8.com/material-outlined/344/unlock.png"
            });
        }

        private async void TapGestureRecognizer_Tapped(Object sender, ItemTappedEventArgs e)
        {
            var selectedProduct = (Category)e.Item;

            if (selectedProduct.Name == "Siparişlerim")
            {
                await Navigation.PushAsync(new Siparislerim());

            }

            if (selectedProduct.Name == "Favorilerim")
            {
                await Navigation.PushAsync(new FavoritePage());
            }

            if (selectedProduct.Name == "Satıcı Sorularım")
            {
                await Navigation.PushAsync(new SaticiSoru());

            }

            if (selectedProduct.Name == "Adreslerim")
            {
                await Navigation.PushAsync(new Adreslerim());

            }

            if (selectedProduct.Name == "Kayıtlı Kartlarım")
            {
                await Navigation.PushAsync(new Kartlarım());

            }

            if (selectedProduct.Name == "Üyelik Bilgilerim")
            {
                await Navigation.PushAsync(new UyelikBilgileri());

            }

            //if (selectedProduct.productName == "İletişim İzinlerim")
            //{
            //    await Navigation.PushAsync(new ());

            //}

            if (selectedProduct.Name == "Şifre Değiştirme")
            {
                await Navigation.PushAsync(new SifreDegistirme());

            }
        }
    }
}

