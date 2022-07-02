using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabAssignment3
{
    internal class Circle : Shape
    {
        public double radius { get; set; }
        public static readonly double PI = 3.14;

        public override double calculateArea()
        {
            return (radius * radius) * PI;
        }

        public override double calculatePerimeter()
        {
            return 2 * PI * radius;
        }
    }
}
