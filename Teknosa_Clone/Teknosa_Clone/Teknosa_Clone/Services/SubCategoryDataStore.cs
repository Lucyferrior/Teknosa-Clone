using System.Collections.ObjectModel;
using System.ComponentModel;
using Teknosa_Clone.Models;
using Xamarin.Forms;

namespace Teknosa_Clone.Services
{

    public class SubCategoryDataStore : ObservableCollection<Category>, INotifyPropertyChanged
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



        public SubCategoryDataStore(string title, ImageSource image, bool expanded = true)
        {
            Title = title;
            Expanded = expanded;
            Image1 = image;
        }

        public static ObservableCollection<SubCategoryDataStore> All { private set; get; }
        public static ObservableCollection<SubCategoryDataStore> All2 { private set; get; }
        public static ObservableCollection<SubCategoryDataStore> All3 { private set; get; }



        static SubCategoryDataStore()
        {
            ObservableCollection<SubCategoryDataStore> Groups = new ObservableCollection<SubCategoryDataStore>{
                new SubCategoryDataStore("Cep Telefonu", "https://reimg-teknosa-cloud-prod.mncdn.com/mnresize/600/600/productimage/125078519/125078519_1_MC/61250704.jpg")
                {
                    new Category{ Name = "Android Telefon"},
                    new Category{ Name = "İOS Telefon"},
                    new Category{ Name = "Tuşlu Telefon"}
                },

                new SubCategoryDataStore("Giyilebilir Teknoloji", "https://reimg-teknosa-cloud-prod.mncdn.com/mnresize/600/600/productimage/780152467/780152467_0_MC/43140919.jpg")
                {
                    new Category{ Name = "Akıllı Saat"},
                    new Category{ Name = "Akıllı Bileklik"},
                    new Category{ Name = "Saat ve Bileklik Aksesuarı"},
                    new Category{ Name = "Akıllı Çocuk Saati"},
                    new Category{ Name = "Akıllı Kıyafet ve Ayakkabı"},
                    new Category{ Name = "Kol Bandı"},
                    new Category{ Name = "Akıllı Gözlük"},
                    new Category{ Name = "Sanal ve Artırılmış Gerçeklik"}
                },

                new SubCategoryDataStore("Kulaklık", "https://reimg-teknosa-cloud-prod.mncdn.com/mnresize/600/600/productimage/110263107/110263107_0_MC/1234.jpg")
                {
                    new Category{ Name = "Bluettoh Kulaklık Aksesuarı"},
                    new Category{ Name = "Kulak İçi Kulaklık"},
                    new Category{ Name = "Bluettoh Kulaklık"},
                    new Category{ Name = "Kulaklık Aksesuarı"},
                    new Category{ Name = "Kulak Üstü Kulaklık"}
                },

                new SubCategoryDataStore("Masaüstü ve Telsiz Telefon", "https://reimg-teknosa-cloud-prod.mncdn.com/mnresize/600/600/productimage/780450001/780450001_0_MC/5cb9da7ee14e43cab8929213e128cd08.jpg")
                { },

                new SubCategoryDataStore("Telefon Aksesuar", "https://reimg-teknosa-cloud-prod.mncdn.com/mnresize/600/600/productimage/145059446/145059446_1_MC/34372092.jpg")
                {
                    new Category{ Name = "Taşınabilir Şarj Aleti"},
                    new Category{ Name = "Ekran Koruyucu"},
                    new Category{ Name = "Selfie Çubuğu"},
                    new Category{ Name = "Telefon Tutucu"},
                    new Category{ Name = "Bluetooth Araç Kiti"},
                    new Category{ Name = "Telefon Yedek Parça"},
                    new Category{ Name = "Telefon Kılıfı"},
                    new Category{ Name = "Telefon Oyun Aksesuarları"},
                    new Category{ Name = "Şarj Aleti"},
                    new Category{ Name = "Şarj Kablosu"},
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

            ObservableCollection<SubCategoryDataStore> Groups2 = new ObservableCollection<SubCategoryDataStore>{
                new SubCategoryDataStore("Laptop, Notebook",""){
                },

                new SubCategoryDataStore("Masaüstü Bilgisayar", ""){
                    new Category { Name = "Apple iMac" },
                    new Category { Name = "Hazır Sistemler" },
                    new Category { Name = "Mini Masaüstü"},
                    new Category { Name = "All In One"},
                },

                new SubCategoryDataStore("Tablet", "")
                {
                },

                new SubCategoryDataStore("Oyuncu Bilgisayarı", "")
                {
                    new Category { Name = "Gaming Masaüstü"},
                    new Category{ Name = "Gaming Laptop"},
                },

                new SubCategoryDataStore("Bilgisayar Bileşenleri", "")
                {
                    new Category{ Name = "Anakart"},
                    new Category{ Name = "Ekran Kartı"},
                    new Category{ Name = "RAM"},
                    new Category{ Name = "Güç Kaynağı"},
                    new Category{ Name = "İşlemci"},
                    new Category{ Name = "Harddisk"},
                    new Category{ Name = "SSD"},
                    new Category{ Name = "Bilgisayar Kasası"},
                },


            };
            All2 = Groups2;

            ObservableCollection<SubCategoryDataStore> Groups3 = new ObservableCollection<SubCategoryDataStore>{
                new SubCategoryDataStore("Televizyon",""){
                },



                 new SubCategoryDataStore("Media Player, Akıllı Tv Kutusu", "")
                {
                    
                },

                 new SubCategoryDataStore("Müzik ve Ses Sistemi", "")
                {
                    
                },

                 new SubCategoryDataStore("Hoparlör", "")
                {
                    
                },

                  new SubCategoryDataStore("Projeksiyon Cihaz ve Aksesuarları", "")
                {
                    
                },

                 new SubCategoryDataStore("Oto Elektroniği", "")
                {
                    
                },

                 new SubCategoryDataStore("Güvenlik Kamera Sistemleri", "")
                {
                    
                },

                  new SubCategoryDataStore("Monitör TV", "")
                {
                   
                },

                 new SubCategoryDataStore("Uydu Alıcıları", "")
                {
                    
                },

                 new SubCategoryDataStore("TV Aksesuarı", "")
                {
                    
                },




            };
            All3 = Groups3;


        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }

}