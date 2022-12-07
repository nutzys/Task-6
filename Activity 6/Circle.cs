using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Activity.Polymorphism
{
    public class Circle : Shape, IPrintable
    {
        public double Radius { get; protected set; }
        public Circle(double radius)
        {
            
            if(radius <= 0)
            {
                throw new ArgumentException("Invalid radius argument");
            }
            Radius = radius;
        }
        /// <summary>
        /// Calculates the area for circle
        /// </summary>
        public override void CalculateArea()
        {
            Area = (2 * 3.14) * Radius;
        }
        public void Print()
        {
            Console.WriteLine("Area for - Circle:" + Area);
        }
    }
}
