using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Ring
    {
        private double _outerRadius;
        private double _innerRadius;
        private Point2D _center;

        public double OuterRadius
        {
            get
            {
                return _outerRadius;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(OuterRadius));
                if (value <= _innerRadius)
                {
                    throw new ArgumentException();
                }
                _outerRadius = value;
            }
        }

        public double InnerRadius
        {
            get
            {
                return _innerRadius;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(InnerRadius));
                if (value >= _outerRadius)
                {
                    throw new ArgumentException();
                }
                _innerRadius = value;
            }
        }

        public Point2D Center { get; set; }

        public double Area
        {
            get
            {
                return (Math.PI * _outerRadius * _outerRadius)-(Math.PI * _innerRadius * _innerRadius);
            }
        }

        public Ring(double outerRadius, double innerRadius, Point2D center)
        {
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
            Center = center;
        }
    }
}
