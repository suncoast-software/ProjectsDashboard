﻿using Dashboard.MVVM.ViewModel;
using Dashboard.Stores;
using System.Windows;
using System.Windows.Input;


namespace Dashboard
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
    }
}
