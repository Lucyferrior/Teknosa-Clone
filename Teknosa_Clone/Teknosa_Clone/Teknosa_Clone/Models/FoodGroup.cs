using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Teknosa_Clone.Models
{

    public class FoodGroup : ObservableCollection<Food>, INotifyPropertyChanged
    {

        private bool _expanded;

        public string Title { get; set; }

        public string CategoryTitle
        {
            get { return string.Format("{0}", Title); }
        }


        public bool Expanded
        {
            get { return _expanded; }
            set
            {
                if (_expanded != value)
                {
                    _expanded = value;
                    OnPropertyChanged("Expanded");
                    OnPropertyChanged("StateIcon");
                }
            }
        }

        public string StateIcon
        {
            get { return Expanded ? "a.png" : "b.png"; }
        }



        public FoodGroup(string title, bool expanded = true)
        {
            Title = title;
            Expanded = expanded;
        }

        public static ObservableCollection<FoodGroup> All { private set; get; }

        static FoodGroup()
        {
            ObservableCollection<FoodGroup> Groups = new ObservableCollection<FoodGroup>{
                new FoodGroup("Telefon"){
                    new Food { Name = "Cep Telefonu", Icon="https://reimg-teknosa-cloud-prod.mncdn.com/mnresize/600/600/productimage/125078519/125078519_1_MC/61250704.jpg" },
                    new Food { Name = "Giyilebilir Teknoloji", Icon="https://reimg-teknosa-cloud-prod.mncdn.com/mnresize/600/600/productimage/780152467/780152467_0_MC/43140919.jpg" },
                    new Food { Name = "Kulaklık", Icon="https://reimg-teknosa-cloud-prod.mncdn.com/mnresize/600/600/productimage/110263107/110263107_0_MC/1234.jpg" },
                    new Food { Name = "Masaüstü ve Telsiz Telefon", Icon="https://reimg-teknosa-cloud-prod.mncdn.com/mnresize/600/600/productimage/780450001/780450001_0_MC/5cb9da7ee14e43cab8929213e128cd08.jpg" },
                    new Food { Name = "Telefon Aksesuar", Icon="https://reimg-teknosa-cloud-prod.mncdn.com/mnresize/600/600/productimage/145059446/145059446_1_MC/34372092.jpg" },

                },
                new FoodGroup("Bilgisayar ve Tablet"){
                    new Food { Name = "Laptop, Notebook", },
                    new Food { Name = "Masaüstü Bilgisayar", },
                    new Food { Name = "pear", },
                }};
            All = Groups;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }

}
