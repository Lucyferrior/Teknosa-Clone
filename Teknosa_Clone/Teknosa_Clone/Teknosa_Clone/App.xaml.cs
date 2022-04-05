using System;
using Teknosa_Clone.Services;
using Teknosa_Clone.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Teknosa_Clone
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
