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
                    Description = "TV Reklamlarında Gördüğünüzü Kaçırmayın!",
                    Title = "Anneler Günü Fırsatları Teknosa'da",
                    ImageSource= ImageSource.FromUri(new Uri("https://img-teknosa-sap.mncdn.com/home/jenerik_tv_reklam_urunleri_220505.jpg"))
                },
                new Slide
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "Anneler Günü Fırsatları Teknosa'da",
                    Description = "Tüm Anneler İçin Hediyeler",
                    ImageSource= ImageSource.FromUri(new Uri("https://img-teknosa-sap.mncdn.com/home/jenerik_tv_reklam_urunleri_220505.jpg"))
                },
                new Slide
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "galaxyASlide",
                    Title = "Yeni Galaxy A serisi ile tanışın.",
                    Description = "",
                    ImageSource= ImageSource.FromUri(new Uri("https://img-teknosa-sap.mncdn.com/home/jenerik_tv_reklam_urunleri_220505.jpg"))
                },
                new Slide
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "xiomiSlide",
                    Title = "Sepette Xiomi Akıllı Bluetooth Tartı Hediye",
                    Description = "Xiomi Mi Mop Pro 2 Robot Süpürge Alımında",
                    ImageSource= ImageSource.FromUri(new Uri("https://img-teknosa-sap.mncdn.com/home/jenerik_tv_reklam_urunleri_220505.jpg"))

                },
                new Slide
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "hediyeSlide",
                    Title = "1 Yıllık Teknoloji Destek Paketi Sepette Hediye",
                    Description = "Seçili Robot Süpürgeler ile birlikte",
                    ImageSource= ImageSource.FromUri(new Uri("https://img-teknosa-sap.mncdn.com/home/jenerik_tv_reklam_urunleri_220505.jpg"))

                },
                new Slide
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "dellSlide",
                    Title = "Sınırları Kaldır, Güvende Kal",
                    Description = "TPM Özelliği ve 2 Yıl Yerinde Servis Garantisi ile",
                    ImageSource= ImageSource.FromUri(new Uri("https://img-teknosa-sap.mncdn.com/home/jenerik_tv_reklam_urunleri_220505.jpg"))

                },
                new Slide
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "intelSlide",
                    Title = "Haftanın Ürünü",
                    Description = "İntel Core İşlemcili Yüksek Performanslı Bilgisayar Teknosa'da",
                    ImageSource= ImageSource.FromUri(new Uri("https://img-teknosa-sap.mncdn.com/home/jenerik_tv_reklam_urunleri_220505.jpg"))

                }
            };
        }
    }
}
