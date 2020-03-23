using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UILib.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CommonServiceMainPage : ContentPage
    {
        public CommonServiceMainPage()
        {
            InitializeComponent();
        }

        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) return;

            if (sender is ListView lv) lv.SelectedItem = null;

        }
    }
}