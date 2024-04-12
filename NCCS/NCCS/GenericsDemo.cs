using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//generics allows all types of data to be passed as a instance variable, parameter on method or constructor
//it is denoted by <> symbol

namespace NCCS
{
    class GenericsDemo <T>
    {
        T a;
        T b;
        public GenericsDemo(T a, T b)
        {
            this.a = a; 
            this.b = b;
        }
        public void sum()
        {
            Console.WriteLine("sum is " + a + b);
        }
    }
}
