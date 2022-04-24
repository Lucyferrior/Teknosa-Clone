using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Teknosa_Clone.ViewModels;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Teknosa_Clone.Models;
namespace Teknosa_Clone.Views
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel _viewModel;
        public MainPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new MainPageViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}