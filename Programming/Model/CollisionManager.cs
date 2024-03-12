using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public static class CollisionManager
    {
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            bool isCollisionWidth = Math.Abs(rectangle1.Center.X - rectangle2.Center.X) < (rectangle1.Width + rectangle2.Width) / 2;
            bool isCollisionLenght = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y) < (rectangle1.Lenght + rectangle2.Lenght) / 2;

            if (isCollisionWidth && isCollisionLenght)
            {
                return true;
            }
            
            return false;
        }

        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            double c = Math.Sqrt(Math.Pow(ring1.Center.X - ring2.Center.X, 2) + Math.Pow(ring1.Center.Y - ring2.Center.Y, 2));
            if (c < (ring1.OuterRadius + ring2.OuterRadius))
            {
                return true;
            }

            return false;
        }
    }
}
