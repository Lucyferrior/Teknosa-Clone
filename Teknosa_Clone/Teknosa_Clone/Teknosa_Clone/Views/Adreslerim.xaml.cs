using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Teknosa_Clone.Views
{	
	public partial class Adreslerim : ContentPage
	{	
		public Adreslerim ()
		{
			InitializeComponent ();
		}

		private async void Button_Clicked(System.Object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new AccountPage());

		}
    }
}

