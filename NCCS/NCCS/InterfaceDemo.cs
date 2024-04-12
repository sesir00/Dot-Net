using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//interface are similar to abstract class but it contains list of abstract mrthod
//all the variable will be automatically constant
namespace NCCS
{
    interface Calculation2
    {
        //list of abstract method
        void sum (int x, int y);
        void diff(int x, int y);
    }
    interface Calculation3
    {
        void div(int x, int y);
    }

    //multiple inheritance
    class Solution1 : Calculation2 , Calculation3
    {
        public void sum (int x, int y)
        {
            Console.WriteLine("Sum is " + (x+y));
        }
        public void diff (int x, int y)
        {
            Console.WriteLine("Diff is " + (x-y));
        }
        public void div(int x, int y)
        {
            Console.WriteLine("Div is " + (x/y));
        }
    }
}
