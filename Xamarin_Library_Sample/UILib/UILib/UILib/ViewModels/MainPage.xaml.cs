using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinCodeLibrary.Services.CommonServices.PlatformServices;
using XamarinCodeLibrary.Views;

namespace XamarinCodeLibrary.ViewModels
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UserElementMainPage());
        }

        private async void Button2_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CommonServiceMainPage());
        }

        private async void Button3_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PlatformServicesMainPage());
        }
    }
}