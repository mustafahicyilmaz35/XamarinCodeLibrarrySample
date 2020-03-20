using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UILib.Views.UserControls.MediaElements
{
    public interface IVideoPicker
    {
        Task<string> GetVideoFileAsync();
    }
}
