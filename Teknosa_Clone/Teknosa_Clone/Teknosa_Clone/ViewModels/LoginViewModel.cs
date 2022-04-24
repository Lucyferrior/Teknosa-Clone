using System;
using System.Collections.Generic;
using System.Text;
using Teknosa_Clone.Views;
using Xamarin.Forms;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Teknosa_Clone.ViewModels
{
    public class LoginViewModel : ContentPage
    {
        public Command LoginCommand { get; }


        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            //await Shell.Current.GoToAsync("//LoginPage");

            await Shell.Current.Navigation.PushAsync(new LoginPage());
        }
    }
}
