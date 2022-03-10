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
        public static ObservableCollection<Grid> Colors { set; get; }

        public MainWindow()
        {
            InitializeComponent();
            //DataContext = new ViewModels();
            this.DataContext = new ViewModels();
            IsButtonEnabled += IsEnable;
            NotButtonEnabled += NotEnable;
            Colors = new ObservableCollection<Grid>();
            //ListColor.ItemsSource = Colors;

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            ButtonPressed?.Invoke();
            //Grid colorCol = new Grid();
            //if (colorCol.Children.Contains())
            
            //Colors.Add(colorCol);
            //var grid = new Grid();
            //ListColor.;
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
