﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using static ColorARGB.MainWindow;

namespace ColorARGB
{
    public class MyColor : ObservableObject
    {
        private Brush brush;

        public Brush Brush
        {
            get { return brush; }
            set
            {
                if (brush != value)
                {
                    brush = value;
                    OnPropertyChanged(nameof(Brush));
                }
            }
        }


        public MyColor()
        {
            this.PropertyChanged += MyColor_PropertyChanged;
        }

        private void MyColor_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Alpha" || e.PropertyName == "Red" || e.PropertyName == "Blue" || e.PropertyName == "Green")
                Brush = new SolidColorBrush(Color.FromArgb(Alpha, Red, Green, Blue));
        }

        private byte alpha;

        public byte Alpha
        {
            get { return alpha; }
            set
            {
                if (alpha != value)
                {
                    alpha = value;
                    OnPropertyChanged(nameof(Alpha));
                }
            }
        }



        private byte red;

        public byte Red
        { 
            get { return red; }
            set
            {
                if (red != value)
                {
                    red = value;
                    OnPropertyChanged(nameof(Red));
                }
            }
        }


        private byte green;

        public byte Green
        {
            get { return green; }
            set
            {
                if (green != value)
                {
                    green = value;
                    OnPropertyChanged(nameof(Green));
                }
            }
        }


        private byte blue;

        public byte Blue
        {
            get { return blue; }
            set
            {
                if (blue != value)
                {
                    blue = value;
                    OnPropertyChanged(nameof(Blue));
                }
            }
        }
    }
}