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
    public partial class MainWindow : Window
    {
        public ObservableCollection<MyColor> Colors { set; get; }
        //public ObservableCollection<Color> Colors { set; get; }

        public MainWindow()
        {
            InitializeComponent();
            //DataContext = new ViewModels();
            this.DataContext = new ViewModels();
            //colors = new ObservableCollection<MyColor>();
            //colors = new ObservableCollection<Color>();
            ListColor.ItemsSource = Colors;

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            /*for (int i = 0; i < 4; i++)
            {
                ListGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
            }
            for (int i = 0; i < 2; i++)
            {
                ListGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            }*/
            //Colors.Add()
            //var selected = (sender as Slider). as st
            //ListColor.Item ;
            /*object selectedItem = ((ListBox)sender).SelectedItem;
            Color color = (Color)selectedItem;
            ListColor.Background = new SolidColorBrush(color);*/
            //var selected = BlockColor.Background;
            //ListColor.Background = BlockColor.Background;
            //ListBoxItem = BlockColor.Background;
            //ListColor.Item.Background. = selected;
            //Colors.Add()
        }
    }
}
