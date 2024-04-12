using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//method overloading refers to two or more methood having same name but different number of parameter
//it is used to achieve static polymorphism
namespace Nccs{
    
    internal class Calculations
    {
        public void calc()
        {
            Console.WriteLine("this is default");
        }
        public void calc(int x, int y)
        {
            Console.WriteLine("sum is " + (x + y));
        }
        //if no of parameters are same the their datatype should be different
        public void calc(double x, double y)
        {
            Console.WriteLine("difference is " + (x - y));
        }
        public int calc(int x, int y,  int z)
        {
            return (x * y * z);
        }
    }
}

    




