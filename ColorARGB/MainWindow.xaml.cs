using System;
using System.Collections.Generic;
using System.Linq;
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
        public MainWindow()
        {
            InitializeComponent();
            var colors = new List<string> { "red", "black", "yellow" };
            Select_Color.ItemsSource = colors;
        }
        private void Show_Info_OnClick(object sender, RoutedEventArgs e)
        {
            var info = $"Width = {Rectangle.Width}\n";
            info += $"Height = {Rectangle.Height}\n";
            info += $"Color = {Rectangle.Fill}";
            MessageBox.Show(info);
        }
        private void Clone_OnClick(object sender, RoutedEventArgs e)
        {
            var clone = new Rectangle
            {
                Fill = Rectangle.Fill,
                Width = Rectangle.Width,
                Height = Rectangle.Height,
                Margin = Rectangle.Margin
            };
            Panel.Children.Add(clone);
        }
    }
}
