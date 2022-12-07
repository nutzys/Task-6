using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Activity.Polymorphism
{
    public class Rectangle : Shape, IPrintable
    {
        public double Length { get; protected set; }
        public double Width { get; protected set; }

        public Rectangle(double length, double width)
        {
           
            if(Width <= 0 || Length <= 0)
            {
                throw new ArgumentException("Negative values are not allowed");
            }
            Length = length;
            Width = width;

        }

        /// <summary>
        /// Calculates the area for a rectangle using Width and Length
        /// Returns Area
        /// </summary>
        public override void CalculateArea()
        {
            Area = Width * Length;
        }

        public void Print()
        {
            Console.WriteLine("Area for - Rectangle: " + Area);
        }
    }
}
