using System;
using Xamarin.Forms;
namespace Teknosa_Clone.Models
{
    class FoodImageCell : ImageCell
    {
        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            var food = (Food)BindingContext;
        }
    }
}