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
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //ListView de seçtiğimiz bir öğeyi tekrar seçebilmemiz için bu kod parçacığını kullanıyoruz.
            if (e.SelectedItem == null) return;

            if (sender is ListView lv) lv.SelectedItem = null;
        }
    }
}