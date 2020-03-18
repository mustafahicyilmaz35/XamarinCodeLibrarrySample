using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UILib.Models;
using UILib.Views.LayoutViews;
using UILib.Views.PageViews;
using UILib.Views.PageViews.CarouselPages;
using UILib.Views.PageViews.MasterDetailPages;
using UILib.Views.PageViews.ModalPages;
using UILib.Views.PageViews.NavigationPages;
using UILib.Views.PageViews.TabbedPages;
using UILib.Views.UserControls;
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

        private async void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //ListView de seçtiğimiz bir öğeyi tekrar seçebilmemiz için bu kod parçacığını kullanıyoruz.
            if (e.SelectedItem == null) return;

            if (sender is ListView lv) lv.SelectedItem = null;

            switch ((e.SelectedItem as UIModel)?.Name)
            {
                case "Content Page":
                    await Navigation.PushAsync(new ContentPageSampleView());
                    break;
                case "Master Detail Page":
                    await Navigation.PushAsync(new MasterDetailPageSampleView());
                    break;
                case "Navigation Page":
                    await Navigation.PushAsync(new NavigationPageSampleView());
                    break;
                case "Tabbed Page":
                    await Navigation.PushAsync(new TabbedPageSimpleView());
                    break;
                case "Carousel Page":
                    await Navigation.PushAsync(new CarouselPageSimpleView());
                    break;
                case "Modal Page":
                    await Navigation.PushAsync(new ModalPageSampleView());
                    break;
                case "Stack Layout":
                    await Navigation.PushAsync(new StackLayoutSampleView());
                    break;
                case "Relative Layout":
                    await Navigation.PushAsync(new RelativeLayoutSampleView());
                    break;
                case "Absolute Layout":
                    await Navigation.PushAsync(new AbsoluteLayoutSimpleView());
                    break;
                case "Grid":
                    await Navigation.PushAsync(new GridSampleView());
                    break;
                case "Flex Layout":
                    await Navigation.PushAsync(new FlexLayoutSampleView());
                    break;
                case "Image":
                    await Navigation.PushAsync(new ImageSampleView());
                    break;
                case "BoxView":
                    await Navigation.PushAsync(new BoxViewSampleView());
                    break;
                case "WebView":
                    await Navigation.PushAsync(new WebViewSampleView());
                    break;
            }
        }
    }
}