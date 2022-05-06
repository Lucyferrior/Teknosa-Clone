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

    public class ProductGroup : ObservableCollection<Products>, INotifyPropertyChanged
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



        public ProductGroup(string title, bool expanded = true)
        {
            Title = title;
            Expanded = expanded;
        }

        public static ObservableCollection<ProductGroup> All { private set; get; }

        static ProductGroup()
        {
            ObservableCollection<ProductGroup> Groups = new ObservableCollection<ProductGroup>{
                new ProductGroup("Telefon"){
                    new Products { productName = "Cep Telefonu", productImage="https://reimg-teknosa-cloud-prod.mncdn.com/mnresize/600/600/productimage/125078519/125078519_1_MC/61250704.jpg" },
                    new Products { productName = "Giyilebilir Teknoloji", productImage="https://reimg-teknosa-cloud-prod.mncdn.com/mnresize/600/600/productimage/780152467/780152467_0_MC/43140919.jpg" },
                    new Products { productName = "Kulaklık", productImage="https://reimg-teknosa-cloud-prod.mncdn.com/mnresize/600/600/productimage/110263107/110263107_0_MC/1234.jpg" },

                }
            
                };
            All = Groups;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }

}