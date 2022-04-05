using System.ComponentModel;
using Teknosa_Clone.ViewModels;
using Xamarin.Forms;

namespace Teknosa_Clone.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}