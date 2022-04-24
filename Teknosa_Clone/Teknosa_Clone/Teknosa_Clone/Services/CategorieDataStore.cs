using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Teknosa_Clone.Models;
using Xamarin.Forms;

namespace Teknosa_Clone.Services
{
    public class CategorieDataStore
    {
        public Collection<Category> categories;
        public CategorieDataStore()
        {
            categories = new Collection<Category> { 
                new Category {
                    Id=Guid.NewGuid().ToString(),
                    Name ="television",
                    Text="Televizyon, Ses ve Görüntü Sistemleri",
                    ImageSource = ImageSource.FromFile("televizyon.png")
                },
                new Category
                {
                    Id= Guid.NewGuid().ToString(),
                    Name = "television",
                    Text = "Televizyon, Ses ve Görüntü Sistemleri",
                    ImageSource = ImageSource.FromFile("telefon.png")
                }
            };
        }
    }
}
