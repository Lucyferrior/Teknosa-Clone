﻿using System;
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
        ObservableCollection<Products> obProducts;


        public AccountPage()
        {
            InitializeComponent();

            AddProducts();

            lstProducts.ItemsSource = obProducts;
        }

       
        public void AddProducts()
        {
            obProducts = new ObservableCollection<Products>();
            obProducts.Add(new Products
            {
                productName = "Siparişlerim",
                productImage = "https://img.icons8.com/ios/344/shopping-cart.png"
            });


            obProducts.Add(new Products
            {
                productName = "Favorilerim",
                productImage = "https://img.icons8.com/ios/344/bookmark-ribbon--v1.png"
            });

            obProducts.Add(new Products
            {
                productName = "Satıcı Sorularım",
                productImage = "https://img.icons8.com/ios/344/ask-question.png"
            });
            obProducts.Add(new Products
            {
                productName = "Adreslerim",
                productImage = "https://img.icons8.com/ios/344/marker--v1.png"
            });
            obProducts.Add(new Products
            {
                productName = "Kayıtlı Kartlarım",
                productImage = "https://img.icons8.com/ios/344/bank-card-back-side.png"
            });
            obProducts.Add(new Products
            {
                productName = "Üyelik Bilgilerim",
                productImage = "https://img.icons8.com/external-dreamstale-lineal-dreamstale/344/external-user-ui-dreamstale-lineal-dreamstale.png"
            });
            obProducts.Add(new Products
            {
                productName = "İletişim İzinlerim",
                productImage = "https://img.icons8.com/small/344/ok--v1.png"
            });
            obProducts.Add(new Products
            {
                productName = "Şifre Değiştirme",
                productImage = "https://img.icons8.com/material-outlined/344/unlock.png"
            });



        }

        private async void TapGestureRecognizer_Tapped(Object sender, ItemTappedEventArgs e)
        {
            var selectedProduct = (Products)e.Item;

            if (selectedProduct.productName == "Siparişlerim")
            {
                await Navigation.PushAsync(new Siparislerim());

            }

            if (selectedProduct.productName == "Favorilerim")
            {
                //await Navigation.PushAsync(new ));

            }

            if (selectedProduct.productName == "Satıcı Sorularım")
            {
                await Navigation.PushAsync(new SaticiSoru());

            }

            if (selectedProduct.productName == "Adreslerim")
            {
                await Navigation.PushAsync(new Adreslerim());

            }

            if (selectedProduct.productName == "Kayıtlı Kartlarım")
            {
                await Navigation.PushAsync(new Kartlarım());

            }

            if (selectedProduct.productName == "Üyelik Bilgilerim")
            {
                await Navigation.PushAsync(new UyelikBilgileri());

            }

            //if (selectedProduct.productName == "İletişim İzinlerim")
            //{
            //    await Navigation.PushAsync(new ());

            //}

            if (selectedProduct.productName == "Şifre Değiştirme")
            {
                await Navigation.PushAsync(new SifreDegistirme());

            }
        }
    }
}

