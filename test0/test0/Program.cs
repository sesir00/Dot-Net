using System;
namespace test0 {
class sampleclass
    {
        //declaring local variable in class sample class
        string name;
        int id;
    //method
    sampleclass(string name, int id) {
        this.name = name;
        this.id = id;
        }
        public static void Main()
        {
            sampleclass sampleclassobj = new sampleclass("shisir", 69);
            Console.WriteLine("Hello"+" "+ sampleclassobj.name+"!");
            Console.ReadLine();
        }
       
    }
}
