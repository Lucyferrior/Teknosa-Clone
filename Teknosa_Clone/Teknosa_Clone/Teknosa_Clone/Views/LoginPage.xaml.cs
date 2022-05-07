using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teknosa_Clone.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Teknosa_Clone.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }
        public void onTapped(object sender, EventArgs e)
        {
            StackLayout senderStack = sender as StackLayout;
            StackLayout stackLayout = senderStack.Parent as StackLayout;
            StackLayout processLayout = stackLayout.Children[1] as StackLayout;

            processLayout.IsVisible = processLayout.IsVisible ? false : true;

            Trace.WriteLine(senderStack + " " + nameof(stackLayout));
            
            if(girisStack == processLayout)
            {
                kayitStack.IsVisible = false;
            }
            if(kayitStack == processLayout)
            {
                girisStack.IsVisible = false;
            }
        }
        public async void OnGirisClicked(object obj, EventArgs e)
        {
            await Shell.Current.Navigation.PushAsync(new AccountPage());
        }
    }
}