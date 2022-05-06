using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Teknosa_Clone.Models;
namespace Teknosa_Clone.Views
{
    public partial class CategoryPage4 : ContentPage
    {
        private ObservableCollection<FoodGroup> _allGroups;
        private ObservableCollection<FoodGroup> _expandedGroups;

        public CategoryPage4(int page)
        {
            int Page = page;
            InitializeComponent();
            if ( Page == 1)
            {
                _allGroups = FoodGroup.All;

            }
            if (Page == 2)
            {
                _allGroups = FoodGroup.All2;

            }
            if (Page == 3)
            {
                _allGroups = FoodGroup.All3;

            }
            if (Page == 4)
            {
                _allGroups = FoodGroup.All3;

            }
            if (Page == 5)
            {
                _allGroups = FoodGroup.All3;

            }
            if (Page == 6)
            {
                _allGroups = FoodGroup.All3;

            }
            if (Page == 7)
            {
                _allGroups = FoodGroup.All3;

            }
            if (Page == 8)
            {
                _allGroups = FoodGroup.All3;

            }
            if (Page == 9)
            {
                _allGroups = FoodGroup.All3;

            }
            if (Page == 10)
            {
                _allGroups = FoodGroup.All3;

            }
            if (Page == 11)
            {
                _allGroups = FoodGroup.All3;

            }
            UpdateListContent();
        }

        private void HeaderTapped(object sender, EventArgs args)
        {
            int selectedIndex = _expandedGroups.IndexOf(
                ((FoodGroup)((ImageButton)sender).CommandParameter));
            _allGroups[selectedIndex].Expanded = !_allGroups[selectedIndex].Expanded;
            UpdateListContent();
        }

        private void UpdateListContent()
        {
            _expandedGroups = new ObservableCollection<FoodGroup>();
            foreach (FoodGroup group in _allGroups)
            {
                //Create new FoodGroups so we do not alter original list
                FoodGroup newGroup = new FoodGroup(group.Title, group.Image1, group.Expanded);
                //Add the count of food items for Lits Header Titles to use
                if (group.Expanded)
                {
                    foreach (Food food in group)
                    {
                        newGroup.Add(food);
                    }
                }
                _expandedGroups.Add(newGroup);
            }
            GroupedView.ItemsSource = _expandedGroups;
        }

        async void GroupedView_ItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            await Navigation.PushAsync(new ProductsPage());
        }
    }
}