using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace UILib.Views.UserControls.MediaElements
{
    public class Helper
    {
        public static async Task CopyVideoIfNotExists(string filename)
        {
            string folder = FileSystem.AppDataDirectory;
            //string folder = Path.GetTempPath();
            string videoFile = Path.Combine(folder, "BickBuckBunny_512kb.mp4");

            if (!File.Exists(videoFile))
            {
                using (Stream inputStream = await FileSystem.OpenAppPackageFileAsync(filename))
                {
                    using (FileStream outputStream = File.Create(videoFile))
                    {
                        await inputStream.CopyToAsync(outputStream);
                    }
                }
            }
        }
    }
}

