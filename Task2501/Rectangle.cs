using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2501
{
    public class Rectangle : Shape
    {
        public double Height;
        public double Width;
        public override double CalculateArea()
        {
           return  Height * Width;
        }
    }
}
