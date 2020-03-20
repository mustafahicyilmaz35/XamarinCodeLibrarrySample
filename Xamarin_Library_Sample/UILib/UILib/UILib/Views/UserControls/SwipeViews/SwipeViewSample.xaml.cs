﻿using System;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UILib.Views.UserControls.SwipeViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwipeViewSample : ContentPage
    {
       
        public SwipeViewSample()
        {
            InitializeComponent();

        }

        private void Favorite_Invoked(object sender, EventArgs e)
        {
            DisplayAlert("Favorite", "Xamarin.Forms is my favorite too!", "<3");
        }

        private void Delete_Invoked(object sender, EventArgs e)
        {
            DisplayAlert("Delete", "Are you sure you want to delete Xamarin.Forms?", "No");
        }
    }
}