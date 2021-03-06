﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Test1.Services;
using Test1.Views;

//Fonts
[assembly: ExportFont("ArialCE.ttf", Alias = "Arial")]
[assembly: ExportFont("Pulchella Free Personal Used.otf", Alias = "Pulchella")]
[assembly: ExportFont("RavenouslyDemoRegular.ttf", Alias = "Ravenously")]

namespace Test1
{
    public partial class App : Application
    {
        public static string FilePath;

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
        }

        public App(string filePath)
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();

            FilePath = filePath;
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
