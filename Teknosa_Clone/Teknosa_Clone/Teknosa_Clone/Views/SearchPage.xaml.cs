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
		
    }
}

