using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//constructor of superclass cannot be called directly by usning sub class when object as constructor
//is only calles when object of particular class is created. to call superclass constructor from sub class
//base keyword is used
namespace Nccs
{
    class student
    {
        private int roll;
        private string name;
        private string faculty;
        //default constructor
        public student() 
        {
            Console.WriteLine("def constructor is std");
        }
        //paramterrized constructor
        public student (int roll, string name, string faculty)
        {
            this.roll = roll;
            this.name = name;
            this.faculty = faculty;
        }
        public void displaystudent()
        {
            Console.WriteLine("roll is " + roll);
            Console.WriteLine("name is " +  name);
            Console.WriteLine("faculty is " + faculty);
        }

    }

    class captain : student
    {
        private string res;
        public captain() : base()
        {
            Console.WriteLine("def cons of captain");
        }
        public captain(string res , int roll , string name , string faculty):base(roll , name , faculty)
        {
            this.res = res;
        }
        public void displaycaptain()
        {
            Console.WriteLine("res is " + res);
        }
    }
}
