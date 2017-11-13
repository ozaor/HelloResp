using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloNew
{
    public class Calculator
    {
        public double division(double x, double y)
        {
       
            if (y == 0)
            {
                throw new System.DivideByZeroException("Can not divide by 0");
            }
            else
                return x / y;
        }
    }
}
