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
                    new Food { Name = "Cep Telefonu", Icon="b.png" },
                    new Food { Name = "Giyilebilir Teknoloji" },
                    new Food { Name = "Kulaklık" },
                    new Food { Name = "Masaüstü ve Telsiz Telefon" },
                    new Food { Name = "Telefon Aksesuar" },

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
