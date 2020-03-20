﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using UILib.Annotations;
using UILib.Views.UserControls.SearchBarViews.SearchBarUtility;
using Xamarin.Forms;

namespace UILib.ViewModels.SearchBarViewModels
{
    public class SearchBarSampleViewModel : INotifyPropertyChanged
    {


        public ICommand PerformSearch => new Command<string>((string query) =>
        {
            SearchResults = DataService.GetSearchResults(query);
        });

        List<string> searchResults = DataService.Fruits;
        public List<string> SearchResults
        {
            get
            {
                return searchResults;
            }
            set
            {
                searchResults = value;
                OnPropertyChanged();
            }
        }





        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
