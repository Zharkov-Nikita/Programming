using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.Model
{
    /// <summary>
    /// Хранит информацию о созданном прямоугольнике.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Высота прямоугольника.
        /// </summary>
        private int _lenght;

        /// <summary>
        /// Ширина прямоугольника.
        /// </summary>
        private int _width;

        /// <summary>
        /// Цвет прямоугольника.
        /// </summary>
        private string _color;

        /// <summary>
        /// Позиция прямоугольника на экране.
        /// </summary>
        private Point2D _center;

        /// <summary>
        /// Общее количество прямоугольников.
        /// </summary>
        private static int _allRectanglesCount = 0;

        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Возвращает и задаёт высоту прямоугольника. Не может быть отрицательной.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задаёт ширину прямоугольника. Не может быть отрицательной.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задаёт цвет прямоугольника. Нет ограничений.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Возвращает и задаёт положение прямоугольника. Не может быть отрицательным.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Возвращает общее количество прямоугольников.
        /// </summary>
        public static int AllRectanglesCount { get; }

        /// <summary>
        /// Возвращает и задаёт уникальный идентификатор прямоугольника. Не может быть отрицательным.
        /// </summary>
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
