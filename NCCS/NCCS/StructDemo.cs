using System;

//structure is a value accepted data type which can store data of similar type. it can have constructor, method but
//cannot be inherited and does not have reference type, doesnot have default constructor 
//it is declared using keyword

namespace NCCS
{
    struct Students
    {
        private int roll;
        private string name;
        private string faculty;
        public Students(int roll, string name, string faculty)
        {
            this.roll = roll;
            this.name = name;
            this.faculty = faculty;
        }

        //can have parameterized constructor
        public void displayStud()
        {
            Console.WriteLine("roll is " + roll);
            Console.WriteLine("name is " + name);
            Console.WriteLine("faculty is " + faculty);
        }

    }
}
