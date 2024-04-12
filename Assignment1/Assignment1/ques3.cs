using System;
//3.	Write a program to demonstrate single level inheritance and multilevel inheritance

namespace Assignment1
{
    class Fourwheeler
    {
        public void FourWheel()
        {
            Console.WriteLine("this is default");
        }
        public string Brand
        {
            get; 
            set; 
        }
        public string Color
        {
            get;
            set;
        }
        public void DisplayFourWheel() 
        {
            Console.WriteLine("Brand of Four Wheel is " + Brand);
            Console.WriteLine("Color of Four Wheeler is " + Color);
        }
    }

    class Bike : Fourwheeler
    {
        public void Bike 
        {
            Console.WriteLine("This is Default");
        }
    }
}
