using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teknosa_Clone.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Teknosa_Clone.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FavoritePage : ContentPage
    {
        public FavoritePage()
        {
            InitializeComponent();
            BindingContext = new FavoritePageViewModel();
        }
    }
}