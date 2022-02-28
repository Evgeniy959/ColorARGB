using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using static ColorARGB.MainWindow;

namespace ColorARGB
{
    public class ViewModels : ObservableObject
    {
        private MyColor selectedColor;
        //public ObservableCollection<MyColor> Colors { set; get; }
        public Grid ColorCol { get; set; }
        public ColorDictionary showColor { get; set; }
        public ViewModels(Grid colorCol)
        {
            ColorCol = colorCol;
            SelectedColor = new MyColor { Alpha = 127, Red = 255, Green = 255, Blue = 0 };
            showColor = new ColorDictionary(SelectedColor, ColorCol);
            MainWindow.ButtonPressed += showColor.AddColor;

            //SelectedColor = new ObservableCollection<MyColor> { Alpha = 127, Red = 255, Green = 255, Blue = 0 };
            //Colors = new ObservableCollection<MyColor>();

        }
        public MyColor SelectedColor
        {
            get { return selectedColor; }
            set
            {
                if (selectedColor != value)
                {
                    selectedColor = value;
                    OnPropertyChanged(nameof(SelectedColor));
                }
            }
        }

    }
}
