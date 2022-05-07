using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Forms;
using Teknosa_Clone.ViewModels;
namespace Teknosa_Clone.Views
{	
	public partial class SearchPage : ContentPage
	{
		public SearchPage ()
		{
			InitializeComponent ();
			BindingContext = new SearchPageViewModel();
		}

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
			Entry entry = sender as Entry;
			if(entry.Text == "")
            {
				barkodImage.IsVisible = true;
				scrollProducts.IsVisible = false;
            }
            else
            {
				barkodImage.IsVisible = false;
				scrollProducts.IsVisible = true;
			}
        }
    }
}

