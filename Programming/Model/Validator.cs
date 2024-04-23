using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Programming.Model
{
    /// <summary>
    /// Выполняет валидацию
    /// </summary>
    static class Validator
    {
        /// <summary>
        /// Проверка на положительное целочисленное значение
        /// </summary>
        /// <param name="value">Передаваемое значение</param>
        /// <param name="name">Имя свойства</param>
        public static void AssertOnPositiveValue(int value, string name)
        {
            if (value < 0)
            {
                throw new ArgumentException("Попытка присвоить некорректное значение в свойство " + name);
            }
        }

        /// <summary>
        /// Проверка на положительное нецелое число
        /// </summary>
        /// <param name="value">Передаваемое значение</param>
        /// <param name="name">Имя свойства</param>
        public static void AssertOnPositiveValue(double value, string name)
        {
            if (value < 0)
            {
                throw new ArgumentException("Попытка присвоить некорректное значение в свойство " + name);
            }
        }

        /// <summary>
        /// Проверка на нахождение целочисленного значения в заданном диапазоне
        /// </summary>
        /// <param name="value">Передаваемое значение</param>
        /// <param name="min">Минимальное значение</param>
        /// <param name="max">Максимальное значение</param>
        /// <param name="name">Имя свойства</param>
        public static void AssertValueInRange(int value, int min, int max, string name)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException("Попытка присвоить некорректное значение в свойство " + name);
            }
        }

        /// <summary>
        /// Проверка на нахождение нецелого числа в заданном диапазоне
        /// </summary>
        /// <param name="value">Передаваемое значение</param>
        /// <param name="min">Минимальное значение</param>
        /// <param name="max">Максимальное значение</param>
        /// <param name="name">Имя свойства</param>
        public static void AssertValueInRange(double value, double min, double max, string name)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException("Попытка присвоить некорректное значение в свойство " + name);
            }
        }
    }
}
