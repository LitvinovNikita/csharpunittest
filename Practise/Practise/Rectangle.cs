using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class Rectangle
    {
        double length;
        double width;

        // Generating constructor
        public Rectangle(double length, double width)
        {
            if(length < 0)
            {
                this.length = 0;
            }
            else
            {
                this.length = length;
            }

            if (width < 0)
            {
                this.width = 0;
            }
            else
            {
                this.width = width;
            }
            
        }

        public double Area()
        {
            
                return length * width;
            
            
        }

        public double Perimeter()
        {
            return 2 * (length + width);
        }
    }
}
