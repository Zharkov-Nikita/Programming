using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Проверяет, пересекают ли друг друга заданные фигуры.
    /// </summary>
    public static class CollisionManager
    {
        /// <summary>
        /// Проверка на пересечение прямоугольников.
        /// </summary>
        /// <param name="rectangle1">Первый прямоугольник</param>
        /// <param name="rectangle2">Второй прямоугольник</param>
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            int xMax1 = rectangle1.Center.X + rectangle1.Width;
            int xMax2 = rectangle2.Center.X + rectangle2.Width;
            
            int yMax1 = rectangle1.Center.Y + rectangle1.Lenght;
            int yMax2 = rectangle2.Center.Y + rectangle2.Lenght;

            if (rectangle1.Center.X >= xMax2 || rectangle2.Center.X >= xMax1)
            {
                return false;
            }

            if (rectangle1.Center.Y >= yMax2 || rectangle2.Center.Y >= yMax1)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Проверка на пересечение колец.
        /// </summary>
        /// <param name="ring1">Первое кольцо</param>
        /// <param name="ring2">Второе кольцо</param>
        /// <returns></returns>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            double c = Math.Sqrt(Math.Pow(ring1.Center.X - ring2.Center.X, 2) + Math.Pow(ring1.Center.Y - ring2.Center.Y, 2));
            if (c < (ring1.OuterRadius + ring2.OuterRadius))
            {
                return true;
            }

            return false;
        }
        //Старый тестовый текст удалён, это новый текст
    }
}
