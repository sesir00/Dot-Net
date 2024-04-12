using System;

//2.Write a program to demonstrate method overloading
namespace Assignment1
{
    class Calculation
    {
        public void calc()
        {
            Console.WriteLine("this is default.");
        }
        public void calc(int x , int y) 
        {
            Console.WriteLine("sum is " + (x + y));
        }
        public void calc(double x , double y)
        {
            Console.WriteLine("diff is " + (x - y ));
        }
        public int calc(int x , int y , int z ) 
        {
            return (x * y * z);
        }
    }
}
