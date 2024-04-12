using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
//inheritance is a process of acquiring properties of one class by anither class.
//such class that inherits other class is subclass,  such class that gets inherited
//by other calls is superclass. sub class can use  all the properties of superclass except
//private member
namespace Nccs
{
    //single level: one or more child class inheritin single parent
    class TwoWheeler
    {
        private int reg;
        private string brand;
        private string name;

        public void setTwoWheeler(int reg,  string brand, string name)
        {
            this.reg = reg;
            this.brand = brand;
            this.name = name;
        }
        public void displayTwoWheeler()
        {
            Console.WriteLine("reg is " + this.reg);
            Console.WriteLine("brand is " + this.brand);
            Console.WriteLine("name is " + this.name);
        }


    }

    //creating subvlass and TwoWheeler is superclass
    class Bike : TwoWheeler
    {
        //Bike is subclass and TwoWheeler is superclass
        private string speed;
        private string fuelcapacity;
        public void setBike(string speed, string fuelcapacity)
        {
            this.speed = speed;
            this.fuelcapacity = fuelcapacity;
        }
        public void displayBike()
        {
            Console.WriteLine("speed is " + this.speed);
            Console.WriteLine("fuel capacity is " + this.fuelcapacity);
        }
    }
}
