using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Teknosa_Clone.ViewModels
{
    public class SearchPageViewModel
    {
        public ICommand BackCommand { get; }
        public Collection<urun> urunler { get; set; }
        public SearchPageViewModel()
        {
            BackCommand = new Command(OnBackButton);
            urunler = new Collection<urun>
            {
                new urun
                {
                    mark = "Sony",
                    description ="Playstation",
                    cost = 5000,
                    imageSource = ImageSource.FromFile("ps.png")
                },
                new urun
                {
                    mark = "Sony",
                    description ="Playstation",
                    cost = 5000,
                    imageSource = ImageSource.FromFile("ps.png")
                }
            };
        }
        public async void OnBackButton(object sender)
        {
            await Shell.Current.Navigation.PopAsync();
        }
        public class urun
        {
            public string mark { get; set; }
            public string description { get; set; }
            public int cost { get; set; }
            public ImageSource imageSource { get; set; }
            public urun()
            {

            }
        }
    }
    
}
