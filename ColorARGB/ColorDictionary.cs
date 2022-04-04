using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ColorARGB
{
    public class ColorDictionary
    {
        private Grid _ColorCol { get; set; }
        private ConverterToHex _Converter { get; set; }
        private ViewColor _ColorViewOperations { get; set; }
        private MyColor _SelectedColor { get; set; }
        public Dictionary<string, MyColor> Colors { set; get; }
        public ColorDictionary(MyColor selectedColor, Grid colorCol)
        {
            ElementCounter.Counter = default;
            _ColorCol = colorCol;
            _SelectedColor = selectedColor;
            _Converter = new ConverterToHex();
            _ColorViewOperations = new ViewColor(_ColorCol, _Converter);
            Colors = new Dictionary<string, MyColor>();
            _ColorViewOperations.ButtonDeletePressed += DeleteColor;
        }
        public void AddColor()
        {
            if (!Colors.ContainsKey(_Converter.ConvertToHEX(_SelectedColor)))
            {
                var color = _SelectedColor.Clone();
                Colors.Add(_Converter.ConvertToHEX(color), color);
                _ColorViewOperations.AddColorToScreen(Colors.Count, color, Colors);
                //MainWindow.NotButtonEnabled?.Invoke();
            }
            else MainWindow.NotButtonEnabled?.Invoke();

        }

        public void DeleteColor(string str)
        {
            var subs = str.Split('_');
            Colors.Remove(subs[1]);
            _ColorViewOperations.UpdateColorOnScreen(Colors);
        }
    }
}
