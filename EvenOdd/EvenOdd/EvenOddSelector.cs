using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
    public class EvenOddSelector
    {
        double num;

        public EvenOddSelector(double num)
        {
            this.num = num;
        }

        public String EvenOdd()
        {
            if(num % 2 ==0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }
        }
    }
}
