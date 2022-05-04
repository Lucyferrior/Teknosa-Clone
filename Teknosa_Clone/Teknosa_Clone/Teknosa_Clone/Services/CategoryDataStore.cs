using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Teknosa_Clone.Models;
using Xamarin.Forms;

namespace Teknosa_Clone.Services
{
    public class CategoryDataStore
    {
        public Collection<Category> categoryCollection;
        public CategoryDataStore()
        {
            categoryCollection = new Collection<Category> {
                new Category
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "television",
                    Text = "Televizyon, Ses ve Görüntü Sistemleri",
                    ImageSource = ImageSource.FromFile("televizyon.png")
                },
                new Category
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "telefon",
                    Text = "Telefon",
                    ImageSource = ImageSource.FromFile("telefon.png")
                },
                new Category
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "beyaz",
                    Text = "Beyaz Eşya ve Ankastre",
                    ImageSource = ImageSource.FromFile("camasir.png")
                },
                new Category
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "fotograf",
                    Text = "Fotoğraf Makinesi ve Kamera",
                    ImageSource = ImageSource.FromFile("fotograf.png")
                },
                new Category
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "tablet",
                    Text = "Bilgisayar ve Tablet",
                    ImageSource = ImageSource.FromFile("tablet.png")
                },
                new Category
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "supurge",
                    Text = "Elektrikli Ev Aletleri",
                    ImageSource = ImageSource.FromFile("supurge.png")
                },
                new Category
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "kisiselBakım",
                    Text = "Kişisel Bakım",
                    ImageSource = ImageSource.FromFile("fon.png")
                },
                new Category
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "sporOutdoor",
                    Text = "Spor Outdoor",
                    ImageSource = ImageSource.FromFile("scooter.png")
                },
                new Category
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Oyun",
                    Text = "Konsol, Oyun ve Oyuncu Ekipmanları",
                    ImageSource = ImageSource.FromFile("ps.png")
                },
                new Category
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "muzik",
                    Text = "Müzik Enstrüman ve Ekipman",
                    ImageSource = ImageSource.FromFile("gitar.png")
                }
            };
        }
    }
}
