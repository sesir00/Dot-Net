using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace @Nccs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--example of method overloading");
            Calculations c1 = new Calculations();
            c1.calc();  //calls first function
            c1.calc(34, 35);    //calls second function
            c1.calc(23.5, 20.5);    //
            int mul = c1.calc(20, 50, 60);
            Console.WriteLine("Multiplication is " +mul);

            Console.WriteLine("--example on single level inheritance--");
            //creating object of child class Bike
            Bike bil = new Bike();
            //using parent property
            bil.setTwoWheeler(101, "bajaj", "pulsar");
            bil.displayTwoWheeler();
            //using own property
            bil.setBike("50", "10");
            bil.displayBike();
            Console.WriteLine("");
            //creating object of parent class (Two wheeler)
            TwoWheeler twl = new TwoWheeler();
            twl.setTwoWheeler(102, "tvs", "apache");
            twl.displayTwoWheeler();
            //twl.setBike("60", "5" ); //error parent cannot access child


            Console.WriteLine("---Example on MultiLevel---");
            //creaiting object of grandchlid (electic car)
            Electriccar ec = new Electriccar();
            Car cr = new Car();
            //using grandparent properties (FourWheels)
            ec.Reg = 101;
            ec.Brand = "honda";
            ec.Type = "fourwheel drive";
            //using parent property (Car)
            ec.Horsepower = 1200;
            //using own property
            ec.Range = 120;
            Console.WriteLine("reg is " + ec.Reg);
            Console.WriteLine("brand is " + ec.Brand);
            Console.WriteLine("type is " +ec.Type);
            Console.WriteLine("horsepower is " +ec.Horsepower);
            Console.WriteLine("range is " +ec.Range);
            Console.WriteLine("");
            //create object of car 
            Car cal = new Car();
            //using parent property(FourWheeler)
            cal.Reg = 1000;
            cal.Brand = "hyndai";
            cal.Type = "twowheel drive";
            //using own property
            cal.Horsepower = 1000;
            //cal.Range = 124; cannot access child property
            Console.WriteLine("reg is  " + cal.Reg);
            Console.WriteLine("barnd is " + cal.Brand);
            Console.WriteLine("type is " +cal.Type);
            Console.WriteLine("horsepower is " + cal.Horsepower);


            Console.WriteLine("---Example of base keyword---");
            captain cap1 = new captain();
            cap1.displaycaptain();
            captain cap2 = new captain("manage class" , 1 , "hari" , "csit");
            cap2.displaycaptain(); //own
            cap2.displaycaptain(); //parent



            Console.ReadKey(); //screen hold
        }
    }
}
