using System.Collections.Generic;
namespace NCCS
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
            Console.WriteLine("Multiplication is " + mul);

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
            Console.WriteLine("type is " + ec.Type);
            Console.WriteLine("horsepower is " + ec.Horsepower);
            Console.WriteLine("range is " + ec.Range);
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
            Console.WriteLine("type is " + cal.Type);
            Console.WriteLine("horsepower is " + cal.Horsepower);


            Console.WriteLine("---Example of base keyword---");
            captain cap1 = new captain();
            cap1.displaycaptain();
            captain cap2 = new captain("manage class", 1, "hari", "csit");
            cap2.displaystudent(); //own
            cap2.displaycaptain(); //parent

            Console.WriteLine("");
            Console.WriteLine("---Example of method overriding---");
            Answer a1 = new Answer();
            a1.calculate( 50 , 40 );
            a1.calculate( 50 , 60, 70 );


            Console.WriteLine("");
            Console.WriteLine("--Example on abstract class--");
            //Calculation1 calc1 = new Calculation1(); error auxa yesma banau na mildeina
            Solve sol = new Solve(5, 10, 15, 20);
            sol.sum(); //normal method of abstract class
            sol.diff(); //own method of solve
            sol.multiply(10, 40); //abstract method 

            Console.WriteLine("");
            Console.WriteLine("--eg on interface--");
            Solution1 sol1 = new Solution1();
            sol1.sum(10 ,10);
            sol1.diff(20, 10);
            sol1.div(20, 2);

            Console.WriteLine("");
            Console.WriteLine("--ex on try catch--");
            ExceptionDemo ed = new ExceptionDemo();
            ed.setException();

            Console.WriteLine("");
            Console.WriteLine("--Ex on ownException--");
            OwnException oe = new OwnException();
            try
            {
                oe.sendAge(15);
            }catch(AgeException a)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("");
            Console.WriteLine("--eg on arrays--");
            ArrayDemo ad = new ArrayDemo();
            ad.setArray();
            ad.setJagged();

            Console.WriteLine("");
            Console.WriteLine("--ex on struct--");
            Students std1 = new Students(1, "ram", "csit");
            std1.displayStud();

            Console.WriteLine("");
            Console.WriteLine("--ex on Generics class--");
            GenericsDemo<int> gd = new GenericsDemo<int>(2, 4);
            gd.sum();

            Console.WriteLine("");
            Console.WriteLine("--Ex on List--");
            ListExDemo li1 = new ListExDemo();
            li1.setList();
            //creating 5 object of labour class and storing in List
            List<Labour> lb = new List<Labour>();
            {
                new Labour()
                {
                    Lid = 1,
                    Name = "ram",
                    WorkType = "construction"
                };
                new Labour()
                {
                    Lid = 2,
                    Name = "sam",
                    WorkType = "IT"
                };
                new Labour()
                {
                    Lid = 3,
                    Name = "gita",
                    WorkType = "management"
                };
                new Labour()
                {
                    Lid = 4,
                    Name = "hari",
                    WorkType = "management"
                };
                new Labour()
                {
                    Lid = 5,
                    Name = "samir",
                    WorkType = "IT"
                };
                //calling get from object list
                foreach (var item in lb)
                {
                    Console.WriteLine("id is " + item.Lid + "name is " + item.Name + "work is " + item.WorkType);
                }
                //sorting list of object using lambda expression
                Console.WriteLine("ascending order according to workType");
                var sortObject = lb.OrderBy(x => x.WorkType);
                foreach (var item in sortObject)
                {
                    Console.WriteLine("work is " + item.WorkType);
                }
            }
            Console.ReadKey(); //screen hold
        }
    }
}
