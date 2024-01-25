using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2501
{
    public class Circle : Shape
    {
        public double Radius;
        public override double CalculateArea()
        {
            return 3.14 * (Radius * Radius);
        }
    }
}
