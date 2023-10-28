using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractTutorial
{
    abstract class Shape
    {
        public abstract double CalculateArea();
    }
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius) { 
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

}
