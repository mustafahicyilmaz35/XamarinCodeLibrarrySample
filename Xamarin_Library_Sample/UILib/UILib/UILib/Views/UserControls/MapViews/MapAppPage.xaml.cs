﻿using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCodeLibrary.Views.UserControls.MapViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapAppPage : ContentPage
    {
        public MapAppPage()
        {
            InitializeComponent();
        }

        private async void OnLocationButtonClicked(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                // https://developer.apple.com/library/ios/featuredarticles/iPhoneURLScheme_Reference/MapLinks/MapLinks.html
                await Launcher.OpenAsync("http://maps.apple.com/?q=394+Pacific+Ave+San+Francisco+CA");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                // opens the Maps app directly
                await Launcher.OpenAsync("geo:0,0?q=394+Pacific+Ave+San+Francisco+CA");
            }
            else if (Device.RuntimePlatform == Device.UWP)
            {
                await Launcher.OpenAsync("bingmaps:?where=394 Pacific Ave San Francisco CA");
            }
        }

        private async void OnDirectionButtonClicked(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                // https://developer.apple.com/library/ios/featuredarticles/iPhoneURLScheme_Reference/MapLinks/MapLinks.html
                await Launcher.OpenAsync("http://maps.apple.com/?daddr=San+Francisco,+CA&saddr=cupertino");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                // opens the 'task chooser' so the user can pick Maps, Chrome or other mapping app
                await Launcher.OpenAsync("http://maps.google.com/?daddr=San+Francisco,+CA&saddr=Mountain+View");
            }
            else if (Device.RuntimePlatform == Device.UWP)
            {
                await Launcher.OpenAsync("bingmaps:?rtp=adr.394 Pacific Ave San Francisco CA~adr.One Microsoft Way Redmond WA 98052");
            }
        }
    }
}
