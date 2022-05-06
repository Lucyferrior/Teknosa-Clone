using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Teknosa_Clone.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShoppingCartPage : ContentPage
    {
        public ShoppingCartPage()
        {
            InitializeComponent();
        }

        private async void ImageButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());

        }
    }
}