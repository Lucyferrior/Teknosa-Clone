using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Teknosa_Clone.Models;
using Xamarin.Forms;
namespace Teknosa_Clone.Services
{
    public class SlideDataStore
    {
        public Collection<Slide> slideCollection;
        public SlideDataStore()
        {
            
            slideCollection = new Collection<Slide>
            {
                new Slide
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "slideRamazan",
                    Title = "Ramazan Ayına Özel Seçtik",
                    Description = "Bu akşam, İhtiyacınız olan Ürünleri inceleme vakti",
                    ImageSource= ImageSource.FromFile("ramazan.webp")
                },
                new Slide
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "slideAnneler",
                    Title = "Anneler Günü Fırsatlaro Teknosa'da",
                    Description = "Tüm Anneler İçin Hediyeler",
                    ImageSource= ImageSource.FromUri(new Uri("https://lh3.googleusercontent.com/cooO04i5VN8zf7O-NeIqJ1GHHRtc06fjq6Wr0dCJao__oloD0yaqoGYRY3dx58Z3oGlgziY4S3UzUv4ivCUa=w1920-h955"))
                },
                new Slide
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "galaxyASlide",
                    Title = "Yeni Galaxy A serisi ile tanışın.",
                    Description = "",
                    ImageSource= ImageSource.FromFile("galaxya.webp")
                },
                new Slide
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "xiomiSlide",
                    Title = "Sepette Xiomi Akıllı Bluetooth Tartı Hediye",
                    Description = "Xiomi Mi Mop Pro 2 Robot Süpürge Alımında",
                    ImageSource= ImageSource.FromFile("xiomi.webp")
                },
                new Slide
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "hediyeSlide",
                    Title = "1 Yıllık Teknoloji Destek Paketi Sepette Hediye",
                    Description = "Seçili Robot Süpürgeler ile birlikte",
                    ImageSource= ImageSource.FromFile("robotsupurge.webp")
                },
                new Slide
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "dellSlide",
                    Title = "Sınırları Kaldır, Güvende Kal",
                    Description = "TPM Özelliği ve 2 Yıl Yerinde Servis Garantisi ile",
                    ImageSource= ImageSource.FromFile("dell.webp")
                },
                new Slide
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "intelSlide",
                    Title = "Haftanın Ürünü",
                    Description = "İntel Core İşlemcili Yüksek Performanslı Bilgisayar Teknosa'da",
                    ImageSource= ImageSource.FromFile("intel.webp")
                },
            };
        }
    }
}
