﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ColorARGB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public delegate void ButtonAddPressedHandler();
    public delegate void ButtonDeletePressedHandler(string str);
    public delegate void IsButtonEnabledHandler();
    public delegate void NotButtonEnabledHandler();
    public partial class MainWindow : Window
    {
        public static ButtonAddPressedHandler ButtonPressed;
        public static IsButtonEnabledHandler IsButtonEnabled;
        public static NotButtonEnabledHandler NotButtonEnabled;

        public MainWindow()
        {
            InitializeComponent();
            //DataContext = new ViewModels();
            this.DataContext = new ViewModels(ColorCol);
            IsButtonEnabled += IsEnable;
            NotButtonEnabled += NotEnable;

    }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            //ButtonPressed?.Invoke();
            //MyColor selectedColor = new MyColor();
            var selectedColor = new ViewModels(ColorCol);
            //selectedColor.SelectedColor = new MyColor { Alpha = 127, Red = 255, Green = 255, Blue = 0 };
            var showColor = new ColorDictionary(selectedColor.SelectedColor, ColorCol);
            showColor.AddColor();
        }
        private void IsEnable()
        {
            Add.IsEnabled = true;
        }
        public void NotEnable()
        {
            Add.IsEnabled = false;
        }

    }
}
