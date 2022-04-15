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
        public ListBox ListColor { get; set; }
        public TextBlock BlockColor { get; set; }
        public ConverterToHex Converter { get; set; }
        public ViewColor _ColorViewOperations { get; set; }
        public ColorDictionary showColor { get; set; }
        public ViewModels()
        {
            Grid colorCol = new Grid();
            ListBox listColor = new ListBox();
            TextBlock blockColor = new TextBlock();
            ConverterToHex converter = new ConverterToHex();
            ColorCol = colorCol;
            ListColor = listColor;
            BlockColor = blockColor;
            Converter = converter;
            SelectedColor = new MyColor { Alpha = 127, Red = 255, Green = 255, Blue = 0 };
            //showColor = new ColorDictionary(SelectedColor, ColorCol);
            //MainWindow.ButtonPressed += showColor.AddColor;
            _ColorViewOperations = new ViewColor(/*ColorCol,*/ ListColor, BlockColor, Converter);
            MainWindow.ButtonPressed += _ColorViewOperations.AddColorToScreen;

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
