using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UILib.Models;
using UILib.Views.ButtonViews;
using UILib.Views.CheckBoxes;
using UILib.Views.LayoutViews;
using UILib.Views.PageViews;
using UILib.Views.PageViews.CarouselPages;
using UILib.Views.PageViews.MasterDetailPages;
using UILib.Views.PageViews.ModalPages;
using UILib.Views.PageViews.NavigationPages;
using UILib.Views.PageViews.TabbedPages;
using UILib.Views.UserControls;
using UILib.Views.UserControls.ActivityIndicators;
using UILib.Views.UserControls.CarouselViews;
using UILib.Views.UserControls.DatePickers;
using UILib.Views.UserControls.MapViews;
using UILib.Views.UserControls.OpenGLs;
using UILib.Views.UserControls.ProgressBars;
using UILib.Views.UserControls.RefreshViews;
using UILib.Views.UserControls.SearchBarViews;
using UILib.Views.UserControls.Sliders;
using UILib.Views.UserControls.Steppers;
using UILib.Views.UserControls.SwipeViews;
using UILib.Views.UserControls.SwitchViews;
using UILib.Views.UserControls.TextUserInterfaceses;
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
                case "OpenGLView":
                    await Navigation.PushAsync(new OpenGLSampleView());
                    break;
                case "Button":
                    await Navigation.PushAsync(new ButtonViewSample());
                    break;
                case "ImageButton":
                    await Navigation.PushAsync(new ImageButtonSimpleView());
                    break;
                case "CheckBox":
                    await Navigation.PushAsync(new CheckBoxSampleView());
                    break;
                case "Slider":
                    await Navigation.PushAsync(new SliderSampleView());
                    break;
                case "Stepper":
                    await Navigation.PushAsync(new StepperSampleView());
                    break;
                case "Map":
                    await Navigation.PushAsync(new MapSampleViews());
                    break;
                case "Media Element":
                    await Navigation.PushAsync(new MediaSampleView());
                    break;
                case "RefreshView":
                    await Navigation.PushAsync(new RefreshViewSample());
                    break;
                case "SearchBar":
                    await Navigation.PushAsync(new SearchBarSampleView());
                    break;
                case "SwipeView":
                    await Navigation.PushAsync(new SwipeViewSample());
                    break;
                case "Switch":
                    await Navigation.PushAsync(new SwitchSampleView());
                    break;
                case "Date Picker":
                    await Navigation.PushAsync(new DatePickerSampleView());
                    break;
                case "Text Demos":
                    await Navigation.PushAsync(new TextMainPage());
                    break;
                case "Activity Indicator":
                    await Navigation.PushAsync(new ActivityIndicatorSampleView());
                    break;
                case "ProgressBar":
                    await Navigation.PushAsync(new ProgressBarSampleView());
                    break;
                case "CarouselView":
                    await Navigation.PushAsync(new CarouselViewSample());
                    break;
            }
        }
    }
}