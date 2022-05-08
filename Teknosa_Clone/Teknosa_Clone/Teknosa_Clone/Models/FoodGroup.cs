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
        public ImageSource Image1 { get; set; }

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
            get { return Expanded ? "https://img.icons8.com/ios/344/chevron--v1.png" : "https://img.icons8.com/external-tanah-basah-glyph-tanah-basah/344/external-Chevron-arrows-tanah-basah-glyph-tanah-basah-3.png"; }
        }



        public FoodGroup(string title, ImageSource image,bool expanded = true)
        {
            Title = title;
            Expanded = expanded;
            Image1 = image;
        }

        public static ObservableCollection<FoodGroup> All { private set; get; }
        public static ObservableCollection<FoodGroup> All2 { private set; get; }
        public static ObservableCollection<FoodGroup> All3 { private set; get; }



        static FoodGroup()
        {
            ObservableCollection<FoodGroup> Groups = new ObservableCollection<FoodGroup>{
                new FoodGroup("Cep Telefonu", "https://reimg-teknosa-cloud-prod.mncdn.com/mnresize/600/600/productimage/125078519/125078519_1_MC/61250704.jpg")
                {
                    new Food{ Name = "Android Telefon"},
                    new Food{ Name = "İOS Telefon"},
                    new Food{ Name = "Tuşlu Telefon"}
                },

                new FoodGroup("Giyilebilir Teknoloji", "https://reimg-teknosa-cloud-prod.mncdn.com/mnresize/600/600/productimage/780152467/780152467_0_MC/43140919.jpg")
                {
                    new Food{ Name = "Akıllı Saat"},
                    new Food{ Name = "Akıllı Bileklik"},
                    new Food{ Name = "Saat ve Bileklik Aksesuarı"},
                    new Food{ Name = "Akıllı Çocuk Saati"},
                    new Food{ Name = "Akıllı Kıyafet ve Ayakkabı"},
                    new Food{ Name = "Kol Bandı"},
                    new Food{ Name = "Akıllı Gözlük"},
                    new Food{ Name = "Sanal ve Artırılmış Gerçeklik"}
                },

                new FoodGroup("Kulaklık", "https://reimg-teknosa-cloud-prod.mncdn.com/mnresize/600/600/productimage/110263107/110263107_0_MC/1234.jpg")
                {
                    new Food{ Name = "Bluettoh Kulaklık Aksesuarı"},
                    new Food{ Name = "Kulak İçi Kulaklık"},
                    new Food{ Name = "Bluettoh Kulaklık"},
                    new Food{ Name = "Kulaklık Aksesuarı"},
                    new Food{ Name = "Kulak Üstü Kulaklık"}
                },

                new FoodGroup("Masaüstü ve Telsiz Telefon", "https://reimg-teknosa-cloud-prod.mncdn.com/mnresize/600/600/productimage/780450001/780450001_0_MC/5cb9da7ee14e43cab8929213e128cd08.jpg")
                { },

                new FoodGroup("Telefon Aksesuar", "https://reimg-teknosa-cloud-prod.mncdn.com/mnresize/600/600/productimage/145059446/145059446_1_MC/34372092.jpg")
                {
                    new Food{ Name = "Taşınabilir Şarj Aleti"},
                    new Food{ Name = "Ekran Koruyucu"},
                    new Food{ Name = "Selfie Çubuğu"},
                    new Food{ Name = "Telefon Tutucu"},
                    new Food{ Name = "Bluetooth Araç Kiti"},
                    new Food{ Name = "Telefon Yedek Parça"},
                    new Food{ Name = "Telefon Kılıfı"},
                    new Food{ Name = "Telefon Oyun Aksesuarları"},
                    new Food{ Name = "Şarj Aleti"},
                    new Food{ Name = "Şarj Kablosu"},
                },
                //new FoodGroup("", "")
                //{
                //    new Food{ Name = ""},
                //    new Food{ Name = ""},
                //    new Food{ Name = ""},
                //    new Food{ Name = ""},
                //    new Food{ Name = ""},
                //    new Food{ Name = ""},
                //    new Food{ Name = ""},
                //    new Food{ Name = ""},
                //    new Food{ Name = ""},
                //    new Food{ Name = ""},
                //},


            };
            All = Groups;

            ObservableCollection<FoodGroup> Groups2 = new ObservableCollection<FoodGroup>{
                new FoodGroup("Laptop, Notebook",""){
                },

                new FoodGroup("Masaüstü Bilgisayar", ""){
                    new Food { Name = "Apple iMac" },
                    new Food { Name = "Hazır Sistemler" },
                    new Food { Name = "Mini Masaüstü"},
                    new Food{ Name = "All In One"},
                },

                new FoodGroup("Tablet", "")
                {
                },

                new FoodGroup("Oyuncu Bilgisayarı", "")
                {
                    new Food{ Name = "Gaming Masaüstü"},
                    new Food{ Name = "Gaming Laptop"},
                },

                new FoodGroup("Bilgisayar Bileşenleri", "")
                {
                    new Food{ Name = "Anakart"},
                    new Food{ Name = "Ekran Kartı"},
                    new Food{ Name = "RAM"},
                    new Food{ Name = "Güç Kaynağı"},
                    new Food{ Name = "İşlemci"},
                    new Food{ Name = "Harddisk"},
                    new Food{ Name = "SSD"},
                    new Food{ Name = "Bilgisayar Kasası"},
                },


            };
            All2 = Groups2;

            ObservableCollection<FoodGroup> Groups3 = new ObservableCollection<FoodGroup>{
                new FoodGroup("Televizyon", ""){
                },

                new FoodGroup("Görüntü Sistemleri", ""){
                    new Food { Name = "Laptop, Notebook", },
                    new Food { Name = "Masaüstü Bilgisayar", },
                    new Food { Name = "pear", },
                }};
            All3 = Groups3;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }

}