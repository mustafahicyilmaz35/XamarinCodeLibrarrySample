using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UILib.Services.CommonServices.EssentialServices
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppThemePage : ContentPage
    {
        public AppThemePage()
        {
            InitializeComponent();

            AppTheme appTheme = AppInfo.RequestedTheme;
            appTheme = AppTheme.Dark;
        }
    }
}