using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.Model
{
    public class Rectangle
    {
        private int _lenght;
        private int _width;
        private string _color;

        public int Lenght
        {
            get
            {
                return _lenght;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _lenght = value;
            }
        }

        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _width = value;
            }
        }

        public string Color { get; set; }

        public Rectangle(int lenght, int width, string color)
        {
            Lenght = lenght;
            Width = width;
            Color = color;
        }

        public Rectangle() { }
    }
}
