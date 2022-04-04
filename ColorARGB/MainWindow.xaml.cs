using System;
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
            ButtonPressed?.Invoke();
        }
        private void IsEnable()
        {
            Add.IsEnabled = true;
        }
        private void NotEnable()
        {
            Add.IsEnabled = false;
        }

    }
}
