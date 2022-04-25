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
        public Collection<Category> categoriesBinding { get; set; }
        public Collection<Slide> slidesBinding { get; set; }

        CategoryDataStore categoryStore = new CategoryDataStore();
        SlideDataStore slideStore = new SlideDataStore();
        public MainPageViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);

            categoriesBinding = categoryStore.categoryCollection;
            slidesBinding = slideStore.slideCollection;
        }
        public ICommand LoginCommand { get; }
        private async void OnLoginClicked(object obj)
        {
            await Shell.Current.Navigation.PushAsync(new LoginPage());
        }
    }
}