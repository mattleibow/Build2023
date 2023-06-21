﻿namespace MauiDemoApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState activationState)
        {
            return new Window
            {
                Page = new NavigationPage(new MainPage())
            };
        }
    }
}