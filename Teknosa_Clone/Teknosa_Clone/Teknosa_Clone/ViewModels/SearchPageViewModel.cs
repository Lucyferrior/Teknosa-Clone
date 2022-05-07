using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Teknosa_Clone.Services;
using Teknosa_Clone.Models;
namespace Teknosa_Clone.ViewModels
{
    public class SearchPageViewModel
    {
        public ICommand BackCommand { get; }
        public Collection<Item> items { get; set; }
        public ItemDataStore itemStore = new ItemDataStore();
        public SearchPageViewModel()
        {
            BackCommand = new Command(OnBackButton);
            items = itemStore.ItemCollection;
        }
        public async void OnBackButton(object sender)
        {
            await Shell.Current.Navigation.PopAsync();
        }
    }
    
}
