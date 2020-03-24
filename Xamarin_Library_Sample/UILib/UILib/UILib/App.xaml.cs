using UILib.Views;
using Xamarin.Forms;
using XamarinCodeLibrary.ViewModels;
using XamarinCodeLibrary.Views;

namespace XamarinCodeLibrary
{
    public partial class App : Application
    {
        public App()
        {
            Device.SetFlags(new string[] { "MediaElement_Experimental"
            });

          


            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
