using System;
using System.Collections.Generic;
using System.ComponentModel;
using Teknosa_Clone.Models;
using Teknosa_Clone.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Teknosa_Clone.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}