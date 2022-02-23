using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ColorARGB.MainWindow;

namespace ColorARGB
{
    public class ViewModels : ObservableObject
    {
        private MyColor selectedColor;
        public ObservableCollection<MyColor> Colors { set; get; }

        public ViewModels()
        {
            SelectedColor = new MyColor { Alpha = 127, Red = 255, Green = 255, Blue = 0 };
            //SelectedColor = new ObservableCollection<MyColor> { Alpha = 127, Red = 255, Green = 255, Blue = 0 };
            Colors = new ObservableCollection<MyColor>();

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
