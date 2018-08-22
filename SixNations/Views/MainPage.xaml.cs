﻿using System;

using SixNations.ViewModels;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace SixNations.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel
        {
            get { return DataContext as MainViewModel; }
        }

        public MainPage()
        {
            InitializeComponent();
            Loaded += MainPage_Loaded;
        }

        private async void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            await ViewModel.LoadAsync(MasterDetailsViewControl.ViewState);
        }
    }
}