using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractTutorial
{
    internal class Rentagle : Shape
    {
        public double width {  get; set; }
        public double height { get; set; }

        public Rentagle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public override double CalculateArea()
        {
            return width * height;
        }
    }
}
