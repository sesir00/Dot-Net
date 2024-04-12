using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//such class declared using abstract keywoord and cannot be instantiated is abstract class
//poiint to remember
//object of abstract class cannot be created 
//abstract class can have constructor 
//abstract class can have normal method as well as abstract method (method declared only not initialized)
//a normal (concrete) class have to inherit abstract class and such normal class should provide body part of 
//all abstract  method contains in abstract class . It is used to provide abstraction
namespace NCCS
{
    abstract class Calculation1
    {
        private int x;
        private int y;
        //can have constructor
        public Calculation1(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        //can have normal method
        public void sum()
        {
            Console.WriteLine("Sum is " +(x+y));
        }
        //can have abstract method
        public abstract void multiply (int a, int b);
    }
    class Solve : Calculation1
    {
        private int a, b;
        public Solve (int a, int b ,int x, int y) : base(x,y)
        {
            this.a = a;
            this.b = b;
        }
        //method of Solve
        public void diff()
        {
            Console.WriteLine("diff is " + (a - b));
        }
        //providing body part of abstract class
        public override void multiply(int a, int b)
        {
            Console.WriteLine("mul is " +(a*b));
        }
    }
}
