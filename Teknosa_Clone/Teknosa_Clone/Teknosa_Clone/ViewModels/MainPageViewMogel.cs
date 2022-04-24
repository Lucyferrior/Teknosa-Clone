using System;
using System.Windows.Input;
using Teknosa_Clone.Views;
using Xamarin.Essentials;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Teknosa_Clone.Services;
using Teknosa_Clone.Models;

namespace Teknosa_Clone.ViewModels
{
    public class MainPageViewModel : ContentPage
    {
        public Collection<Categorie> Items { get; set; }
        public MainPageViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
            Items = getCategories();
        }
        private Collection<Categorie> getCategories()
        {
            Collection<Categorie> _categories = new Collection<Categorie>();
            _categories = new Collection<Categorie>
            {
                new Categorie
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "television",
                    Text = "Televizyon, Ses ve Görüntü Sistemleri",
                    ImageSource = ImageSource.FromFile("televizyon.png")
                },
                new Categorie
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "telefon",
                    Text = "Telefon",
                    ImageSource = ImageSource.FromFile("telefon.png")
                },
                new Categorie
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "beyaz",
                    Text = "Beyaz Eşya ve Ankastre",
                    ImageSource = ImageSource.FromFile("camasir.png")
                },
                new Categorie
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "fotograf",
                    Text = "Fotoğraf Makinesi ve Kamera",
                    ImageSource = ImageSource.FromFile("fotograf.png")
                },
                new Categorie
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "tablet",
                    Text = "Bilgisayar ve Tablet",
                    ImageSource = ImageSource.FromFile("tablet.png")
                },
                new Categorie
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "supurge",
                    Text = "Elektrikli Ev Aletleri",
                    ImageSource = ImageSource.FromFile("supurge.png")
                },
                new Categorie
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "kisiselBakım",
                    Text = "Kişisel Bakım",
                    ImageSource = ImageSource.FromFile("fon.png")
                },
                new Categorie
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "sporOutdoor",
                    Text = "Spor Outdoor",
                    ImageSource = ImageSource.FromFile("scooter.png")
                },
                new Categorie
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Oyun",
                    Text = "Konsol, Oyun ve Oyuncu Ekipmanları",
                    ImageSource = ImageSource.FromFile("ps.png")
                },
                new Categorie
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "muzik",
                    Text = "Müzik Enstrüman ve Ekipman",
                    ImageSource = ImageSource.FromFile("gitar.png")
                }
            };
            return _categories;
        }
        public ICommand LoginCommand { get; }
        private async void OnLoginClicked(object obj)
        {
            await Shell.Current.Navigation.PushAsync(new LoginPage());
        }
    }
}