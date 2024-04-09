using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Programming.Model.Geometry
{
    static class RectangleFactory
    {
        static Random rand = new Random();
        public static Model.Color[] _color = Enum.GetValues(typeof(Model.Color)).Cast<Model.Color>().ToArray(); //Перечисление цветов

        public static Rectangle Randomize()
        {
            Rectangle rectangle = new Rectangle(rand.Next(30, 121), rand.Next(30, 121), _color[rand.Next(0, 9)].ToString(), new Point2D(rand.Next(5, 301), rand.Next(5, 301)));
            return rectangle;
        }
    }
}
