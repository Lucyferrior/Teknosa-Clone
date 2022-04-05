using System;
using System.Collections.Generic;
using Teknosa_Clone.ViewModels;
using Teknosa_Clone.Views;
using Xamarin.Forms;

namespace Teknosa_Clone
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
