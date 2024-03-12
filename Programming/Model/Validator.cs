using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Programming.Model
{
    static class Validator
    {
        public static void AssertOnPositiveValue(int value, string name)
        {
            if (value < 0)
            {
                throw new ArgumentException("Попытка присвоить некорректное значение в свойство " + name);
            }
        }

        public static void AssertOnPositiveValue(double value, string name)
        {
            if (value < 0)
            {
                throw new ArgumentException("Попытка присвоить некорректное значение в свойство " + name);
            }
        }

        public static void AssertValueInRange(int value, int min, int max, string name)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException("Попытка присвоить некорректное значение в свойство " + name);
            }
        }

        public static void AssertValueInRange(double value, double min, double max, string name)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException("Попытка присвоить некорректное значение в свойство " + name);
            }
        }
    }
}
