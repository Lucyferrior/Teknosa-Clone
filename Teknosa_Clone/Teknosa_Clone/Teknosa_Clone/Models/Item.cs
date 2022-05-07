using System;
using Xamarin.Forms;

namespace Teknosa_Clone.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Mark { get; set; }
        public string Description { get; set; }
        public int Cost { get; set; }
        public ImageSource ImageSource { get; set; }
    }
}