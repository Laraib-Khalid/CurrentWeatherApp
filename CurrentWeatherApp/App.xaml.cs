﻿using CurrentWeatherApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CurrentWeatherApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new CurrentWeatherPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
