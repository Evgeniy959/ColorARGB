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
        // команда добавления нового объекта
        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand(obj =>
                  {
                      MyColor color = new MyColor();
                      Colors.Insert(0, color);
                      SelectedColor = color;
                  }));
            }
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
