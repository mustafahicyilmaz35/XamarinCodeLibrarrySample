using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UILib.Views.UserControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MediaSampleView : ContentPage
    {

        //Bu elementin çalılşması için app.xaml.cs classı içerisinde  Device.SetFlags(new string[] { "MediaElement_Experimental" }); deyimini eklemeliyiz.

        public MediaSampleView()
        {
            InitializeComponent();
        }
    }
}