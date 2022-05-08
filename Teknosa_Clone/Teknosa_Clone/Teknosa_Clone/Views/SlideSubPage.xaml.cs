using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Teknosa_Clone.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SlideSubPage : ContentPage
    {
        public SlideSubPage()
        {
            InitializeComponent();
            Frame frame = new Frame();
        }
    }
}