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
                    Mark = "Sony",
                    Description ="Playstation",
                    Cost = 5000,
                    ImageSource = ImageSource.FromFile("ps.png")
                },
                new Item
                {
                    Mark = "Sony",
                    Description ="Playstation",
                    Cost = 5000,
                    ImageSource = ImageSource.FromFile("ps.png")
                }
            };
        }
    }
}
