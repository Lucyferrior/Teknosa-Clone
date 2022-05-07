using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Teknosa_Clone.Models;
using Teknosa_Clone.Services;

namespace Teknosa_Clone.ViewModels
{
    public class FavoritePageViewModel
    {
        public Collection<Item> items { get; }
        public ItemDataStore itemStore = new ItemDataStore();
        public FavoritePageViewModel()
        {
            items = itemStore.ItemCollection;
        }
    }
}
