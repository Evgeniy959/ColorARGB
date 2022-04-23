using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ColorARGB 
{
    public class ViewColor
    {
        public event ButtonDeletePressedHandler ButtonDeletePressed;
        private Grid _ColorCol { get; set; }
        private ConverterToHex _Converter { get; set; }
        public static ObservableCollection<Grid> Colors { set; get; }
        private ListBox ListColor { get; set; }
        private TextBlock BlockColor { get; set; }


        //public ViewColor(Grid colorCol, ConverterToHex converter)
        public ViewColor(/*Grid colorCol,*/ ListBox listColor, TextBlock blockColor, ConverterToHex converter)
        {
            //_ColorCol = colorCol;
            _Converter = converter;
            Colors = new ObservableCollection<Grid>();
            //colors = new Dictionary<string, MyColor>();
            /*ListColor = new ListBox();
            BlockColor = new TextBox();*/
            BlockColor = blockColor;
            ListColor = listColor;
            ListColor.ItemsSource = Colors;
            ButtonDeletePressed += DeleteCol;
        }
        //public void AddColorToScreen(int count, MyColor color, Dictionary<string, MyColor> colors)
        public void AddColorToScreen()
        {
            _ColorCol = new Grid();
            _ColorCol.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(100) });
            _ColorCol.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(350) });
            _ColorCol.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(100) });
            for (int i = 0; i < 3; i++)
            {
                var info = new StackPanel();
                info.Orientation = Orientation.Horizontal;
                Grid.SetColumn(info, i);
                if (i == 0) info.Children.Add(new Label { Margin = new Thickness(10, 10, 10, 10), MinWidth = 80, Content = "#X567F" });
                if (i == 1) info.Children.Add(new TextBlock { Margin = new Thickness(10, 10, 10, 10), MinWidth = 330, MinHeight = 30, Background = BlockColor.Background });
                if (i == 2) info.Children.Add(new Button { Margin = new Thickness(10, 10, 10, 10), MinWidth = 80, MinHeight = 30, Content = "Delete", Name = "Del",  /*$"b_{_Converter.ConvertToHEX(color)}_b"*/ });
                _ColorCol.Children.Add(info);
                foreach (var item in info.Children)
                {
                    if (item is Button)
                    {
                        (item as Button).Click += DeleteButton_Click;
                    }
                }

            }
            Colors.Add(_ColorCol);
        }
        public void DeleteCol()
        {
            /*int i = 0;
           _ColorCol.Children.Clear();
            //Colors[i].Children.Clear();
            _ColorCol.ColumnDefinitions.Clear();
            _ColorCol.RowDefinitions.Clear();
            //Colors[i].ColumnDefinitions.Clear();
            //ListColor.SelectedItem.Clear();*/
            for (int i = 0; i < Colors.Count; i++)
            {
                if (i == 2)
                    Colors[i].Children.Clear();
                //Colors[i].ColumnDefinitions.Clear();
            }
        }

        /*public void UpdateColorOnScreen(Dictionary<string, MyColor> colors)
        {
            _ColorCol.Children.Clear();
            _ColorCol.ColumnDefinitions.Clear();
            _ColorCol.RowDefinitions.Clear();
            ElementCounter.Counter = 0;
            foreach (var item in colors)
            {
                AddColorToScreen(ElementCounter.Counter + 1, item.Value, colors);

            }
        }*/
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            //ButtonDeletePressed?.Invoke((sender as Button).Name);
            ButtonDeletePressed?.Invoke();
        }
    }
}
