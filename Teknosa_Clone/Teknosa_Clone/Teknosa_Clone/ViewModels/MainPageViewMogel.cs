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
    public class MainPageViewModel : NavigationPage
    {
        public ICommand LoginCommand { get; }
        public ICommand SearchCommand { get; }

        public Collection<Category> categoriesBinding { get; set; }
        public Collection<Slide> slidesBinding { get; set; }
        CategoryDataStore categoryStore = new CategoryDataStore();
        SlideDataStore slideStore = new SlideDataStore();
        public MainPageViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
            SearchCommand = new Command(OnSearchClicked);
            categoriesBinding = categoryStore.categoryCollection;
            slidesBinding = slideStore.slideCollection;
        }
        private async void OnLoginClicked(object obj)
        {
            await Shell.Current.Navigation.PushAsync(new LoginPage(),true);
        }
        private async void OnSearchClicked (object obj)
        {
            await Shell.Current.Navigation.PushAsync (new SearchPage(),true);
        }
    }
}