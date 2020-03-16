using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using UILib.Annotations;
using UILib.Models;

namespace UILib.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {


        private List<UIModel> _myUserUI;

        public List<UIModel> MyUserUI
        {
            get => _myUserUI;
            set
            {
                _myUserUI = value;
                OnPropertyChanged(nameof(_myUserUI));
            }

        }



        public MainPageViewModel()
        {
            MyUserUI = new List<UIModel>
            {
                new UIModel{UIType = "Layout", Name = "Stack Layout"},
                new UIModel{UIType = "Layout", Name = "Relative Layout"},
                new UIModel{UIType = "Layout", Name = "Absolute Layout"},
                new UIModel{UIType = "Layout", Name = "Grid"},

            };
        }




        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
