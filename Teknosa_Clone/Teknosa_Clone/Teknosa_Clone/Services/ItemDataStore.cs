using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Teknosa_Clone.Models;
using Xamarin.Forms;

namespace Teknosa_Clone.Services
{
    public class ItemDataStore
    {
        public Collection<Item> ItemCollection;
        public ItemDataStore()
        {
           ItemCollection = new Collection<Item>
            {
                new Item
                {
                    ImageSource = "https://reimg-teknosa-cloud-prod.mncdn.com/mnresize/600/600/productimage/125077799/125077799_0_MC/1234.jpg",
                    Description = "iPhone 11 128GB Akıllı Telefon Siyah",
                    Cost = 12499,
                    Mark = "Apple"
                },
                new Item
                {
                   ImageSource = "https://reimg-teknosa-cloud-prod.mncdn.com/mnresize/600/600/productimage/125077803/125077803_0_MC/1234.jpg",
                   Description = "iPhone 11 128GB Akıllı Telefon Mor",
                   Cost = 12499,
                   Mark = "Apple"
                },
                new Item
                {
                    Mark = "Sony",
                    Description ="Playstation",
                    Cost = 5000,
                    ImageSource = ImageSource.FromFile("ps.png")
                },

                new Item
                {
                    Mark = "Electrolux",
                    Description = "PC91-ALRGT Pure C9 Toz Torbasız Elektrikli Süpürge",
                    Cost = 3999,
                    ImageSource = "https://reimg-teknosa-cloud-prod.mncdn.com/mnresize/600/600/productimage/787110136/787110136_0_MC/bb56c364785c4d07a8234ed6e24c762a.png"
                }
                
            };
        }
    }
}
