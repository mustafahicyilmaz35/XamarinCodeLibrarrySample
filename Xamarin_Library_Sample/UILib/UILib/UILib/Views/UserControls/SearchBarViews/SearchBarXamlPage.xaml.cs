using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UILib.Views.UserControls.SearchBarViews.SearchBarUtility;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UILib.Views.UserControls.SearchBarViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchBarXamlPage : ContentPage
    {
        public SearchBarXamlPage()
        {
            InitializeComponent();
        }

        private void OnSearchButtonPressed(object sender, EventArgs e)
        {
            searchResults.ItemsSource = DataService.GetSearchResults(searchBar.Text);
        }
    }
}