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
        public static Dictionary<string, MyColor> colors { set; get; }
        private MyColor color { get; set; }
        private Grid _ColorCol { get; set; }
        private ConverterToHex _Converter { get; set; }
        private ViewColor _ColorViewOperations { get; set; }
        //private Grid _ColorCol { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            //DataContext = new ViewModels();
            this.DataContext = new ViewModels();
            IsButtonEnabled += IsEnable;
            NotButtonEnabled += NotEnable;
            Colors = new ObservableCollection<Grid>();
            colors = new Dictionary<string, MyColor>();
            _ColorCol = new Grid();
            ListColor.ItemsSource = Colors;
            //var _Converter = new ConverterToHex();
            //ListColor.ColorCol.

            

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            /*var _Converter = new ConverterToHex();
            var _ColorViewOperations = new ViewColor(_ColorCol, _Converter);*/
            //var color = _SelectedColor.Clone();
            /*Colors.Add(_Converter.ConvertToHEX(color), color);
            _ColorViewOperations.AddColorToScreen(Colors.Count, color, Colors);*/

            /*if (!Colors.ContainsKey(_Converter.ConvertToHEX(_SelectedColor)))
            {
                var color = _SelectedColor.Clone();
                Colors.Add(_Converter.ConvertToHEX(color), color);
                _ColorViewOperations.AddColorToScreen(Colors.Count, color, Colors);

            }
            else MainWindow.NotButtonEnabled?.Invoke();*/
            //ButtonPressed?.Invoke();
            //Grid colorCol = new Grid();
            //if (colorCol.Children.Contains())
            //var col = 

            //Colors.Add(_Converter.ConvertToHEX(color), color);

            //var grid = new Grid();

            //Colors.Clear();

            //ColorCol.ColumnDefinitions.Clear();

            //grid.Children.Add(new TextBlock { Margin = new Thickness(10, 10, 10, 10), MinWidth = 330, MinHeight = 30, Background = colors[_Converter.ConvertToHEX(color)].Brush });
            /*Colors.Add(grid);
            grid.ColumnDefinitions.Clear();*/
            //Colors.Clear();
            //grid.Clear();
            //ListColor.Background = */

            //var _ColorCol = new Grid();
            
            _ColorCol.ColumnDefinitions.Clear();
            //_ColorCol.RowDefinitions.Clear();
            //Colors.Clear();

            _ColorCol.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(100) });
            _ColorCol.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(350) });
            _ColorCol.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(100) });
            //_ColorCol.RowDefinitions.Add(new RowDefinition { Height = new GridLength(50) });
            //_ColorCol.RowDefinitions.Clear();
            //Colors.Clear();
            //Colors.Add(_ColorCol);
            //ListColor.Items.Clear();
            for (int i = 0; i < 3; i++)
            {
                //var info = new StackPanel();
               
                var info = new StackPanel();
                info.Orientation = Orientation.Horizontal;
                //Grid.SetRow(info, j);
                Grid.SetColumn(info, i);
                /*if (i == 0) info.Children.Add(new Label { Margin = new Thickness(10, 10, 10, 10), MinWidth = 80, Content = $"#{_Converter.ConvertToHEX(color)}" });
                if (i == 1) info.Children.Add(new TextBlock { Margin = new Thickness(10, 10, 10, 10), MinWidth = 330, MinHeight = 30, Background = colors[_Converter.ConvertToHEX(color)].Brush });
                if (i == 2) info.Children.Add(new Button { Margin = new Thickness(10, 10, 10, 10), MinWidth = 80, MinHeight = 30, Content = "Delete", Name = $"b_{_Converter.ConvertToHEX(color)}_b" });*/

                if (i == 0) info.Children.Add(new Label { Margin = new Thickness(10, 10, 10, 10), MinWidth = 80, Content = "rrrrwwww" });
                //if (i == 1) info.Children.Add(new TextBlock { Margin = new Thickness(10, 10, 10, 10), MinWidth = 80, Background = color.Brush });
                if (i == 1) info.Children.Add(new TextBlock { Margin = new Thickness(10, 10, 10, 10), MinWidth = 330, MinHeight = 30, Background = BlockColor.Background });
                if (i == 2) info.Children.Add(new Button { Margin = new Thickness(10, 10, 10, 10), MinWidth = 80, MinHeight = 30, Content = "Delete"/*, Name = $"b_{_Converter.ConvertToHEX(color)}_b"*/ });
                _ColorCol.Children.Add(info);
                Colors.Add(_ColorCol);

                //Colors.
                //break;

            }
            
                //_ColorCol.Children.Add(info);
                //Colors.Add(new Grid());
                //ListColor.Items.Clear();
                           
            
        }
        private void IsEnable()
        {
            Add.IsEnabled = true;
        }
        private void NotEnable()
        {
            Add.IsEnabled = false;
        }
        private Grid Clone()
        {
            return new Grid(); 
        }


    }
}
