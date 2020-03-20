using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using UILib.Droid;
using UILib.Views.UserControls.MediaElements;

[assembly:Xamarin.Forms.Dependency(typeof(VideoPicker))]
namespace UILib.Droid
{
    public class VideoPicker : IVideoPicker
    {
        public Task<string> GetVideoFileAsync()
        {
            Intent intent = new Intent();
            intent.SetType("video/*");
            intent.SetAction(Intent.ActionGetContent);

            MainActivity activity = MainActivity.Current;

            activity.StartActivityForResult(Intent.CreateChooser(intent, "SelectVideo"), MainActivity.PickImageId);

            // Save the TaskCompletionSource object as a MainActivity property;
            activity.PickImageTaskCompletionSource = new TaskCompletionSource<string>();

            // Return Task object
            return activity.PickImageTaskCompletionSource.Task;
        }
    }
}