using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabAssignment3
{
    internal class Rectangle : Shape
    {
        public int length { get; set; }
        public int width { get; set; }

        public override double calculateArea()
        {
            return length * width;
        }

        public override double calculatePerimeter()
        {
            return (length * 2) + (width * 2);
        }
    }
}
