
//1.	Write a program to show class, constructor, properties and method
namespace Assignment1
{
    class Car
    {
        //default constructor
        public Car() 
        {
            Console.WriteLine("This is a default Constructor. ");
        }
        //properties
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        //method
        public void Start()
        {
            Console.WriteLine("The car has started.");
        }
        public void carInfo(string name, string model , int year)
        {
            Console.WriteLine("Name of car is " +  name);
            Console.WriteLine("Model of car is " + model);
            Console.WriteLine("Year of car is " + year);
        }


    }
}
