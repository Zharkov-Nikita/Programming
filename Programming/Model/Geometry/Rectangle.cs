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
        private Point2D _center;
        private static int _allRectanglesCount = 0;
        private readonly int _id;

        public int Lenght
        {
            get
            {
                return _lenght;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Lenght));
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
                Validator.AssertOnPositiveValue(value, nameof(Width));
                _width = value;
            }
        }

        public string Color { get; set; }

        public Point2D Center { get; set; }

        public static int AllRectanglesCount { get; }

        public int Id { get; private set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="lenght">Длина. Не может быть отрицательным.</param>
        /// <param name="width">Ширина. Не может быть отрицательным.</param>
        /// <param name="color">Цвет. Нет ограничений.</param>
        public Rectangle(int lenght, int width, string color, Point2D center)
        {
            Lenght = lenght;
            Width = width;
            Color = color;
            Center = center;
            Id = _allRectanglesCount;
            _allRectanglesCount++;
        }

        public Rectangle() { }
    }
}
