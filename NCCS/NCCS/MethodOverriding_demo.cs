using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//if superclass and subclass have same method (same parameter, same name, same return type)
//then such condition is method overriding. it is used to achieve dynamic polymorphism: overriding 
//is recognize in run time
//two keyword sre used in method overriding
//1. virtual : used to represent overiden method of superclass
////2. override : used to represent overriden method of subclass
/////to call superclass's overriden method from subclass base keyword should be used
namespace NCCS
{
    class Question
    {
        public virtual void calculate(int x, int y)
        {
            Console.WriteLine("Sum is " +(x+y));
        }
        public virtual void calculate(int x , int y, int z)
        {
            Console.WriteLine("mul is " + (x*y*z));
        }
    }
    class Answer : Question
    {
        //method overriden condition
        public override void calculate(int x, int y)
        {
            //calls calculate with two parameter of superclass
            base.calculate(x, y);
            Console.WriteLine("diff is " + (x-y));
        }
        public override void calculate(int x, int y, int z)
        {
            base.calculate( x , y , z );
            Console.WriteLine("simplify " + (x*y+z));
        }
    }
}
