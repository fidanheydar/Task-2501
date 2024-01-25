using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2501
{
    public class ShapeManager
    {
        Shape[] shapes = new Shape[0];
        private const int _maxCircleCount = 10;
        private const int _maxRectangleCount = 10;

        public Shape[] Shapes => shapes;

        public int GetCircleCount()
        {
            int count = 0;
            for (int i = 0; i < shapes.Length; i++)
            {
                if (shapes[i] is Circle)
                {
                    count++;
                }
            }
            return count;
        }
        public Circle[] GetCircles()
        {
            Circle[] circles = new Circle[GetCircleCount()];
            int index = 0;

            for (int i = 0; i < shapes.Length; i++)
            {
                if (shapes[i] is Circle)
                {
                    circles[index++] = (Circle)shapes[i];
                }
            }
            return circles;
        }
        public double GetTotalCircleAreas()
        {
            double totalArea = 0;

            for (int i = 0; i < shapes.Length; i++)
            {
                if (shapes[i] is Circle)
                {
                    totalArea += shapes[i].CalculateArea();
                }
            }
            return totalArea;
        }

        public int GetSquareCount()
        {
            int squareCount = 0;

            for (int i = 0; i < shapes.Length; i++)
            {
                if (shapes[i] is Rectangle && ((Rectangle)shapes[i]).Width == ((Rectangle)shapes[i]).Height)
                {
                    squareCount++;
                }
            }
            return squareCount;
        }

        public void AddShape(Shape shape)
        {
            if (shapes.Length < _maxCircleCount + _maxRectangleCount)
            {
                if ((shape is Rectangle && GetSquareCount() < _maxRectangleCount) || (shape is Circle && GetCircleCount() < _maxCircleCount))
                {
                    Array.Resize(ref shapes, shapes.Length + 1);
                    shapes[shapes.Length - 1] = shape;
                }
                else Console.WriteLine("Type limit is full and type is incorrect");
            }
            else  Console.WriteLine("Limit is full");

        }
    }
}