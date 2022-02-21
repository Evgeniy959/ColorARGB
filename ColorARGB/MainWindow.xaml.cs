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
        //public ObservableCollection<MyColor> colors { set; get; }
        public ObservableCollection<Color> colors { set; get; }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new ViewModels();
            //colors = new ObservableCollection<MyColor>();
            colors = new ObservableCollection<Color>();
            ListColor.ItemsSource = colors;

        }
        public class ObservableObject : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;

            protected void OnPropertyChanged([CallerMemberName] string prop = "")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            //colors.Add
            //var selected = (sender as Slider). as st
            //ListColor.SelectedItem = C;
        }
    }
}
