using System;
using System.Collections.Generic;
<<<<<<< HEAD

using Xamarin.Forms;

namespace Teknosa_Clone.Views
{	
	public partial class ShoppingCartPage : ContentPage
	{	
		public ShoppingCartPage ()
		{
			InitializeComponent ();
		}
	}
}

=======
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Teknosa_Clone.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShoppingCartPage : ContentPage
    {
        public ShoppingCartPage()
        {
            InitializeComponent();
        }
    }
}
>>>>>>> main
