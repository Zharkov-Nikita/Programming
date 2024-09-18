using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Выполняет валидацию
    /// </summary>
    static class ValueValidator
    {
        /// <summary>
        /// Проверка на длину строкового значения
        /// </summary>
        /// <param name="value">Передаваемое значение</param>
        /// <param name="maxLength">Максимальное значение</param>
        /// <param name="propertyName">Имя свойства</param>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException(propertyName + " должен быть меньше " + maxLength + " символов");
            }
        }
    }
}
