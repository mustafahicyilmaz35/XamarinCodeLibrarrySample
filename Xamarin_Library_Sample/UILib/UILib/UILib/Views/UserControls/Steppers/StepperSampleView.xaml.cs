﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCodeLibrary.Views.UserControls.Steppers
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StepperSampleView : ContentPage
    {
        public ICommand NavigateCommand { get; private set; }
        public StepperSampleView()
        {
            InitializeComponent();

            NavigateCommand = new Command<Type>(async (Type pageType) =>
            {
                Page page = (Page)Activator.CreateInstance(pageType);
                await Navigation.PushAsync(page);
            });
            BindingContext = this;

        }
    }
}