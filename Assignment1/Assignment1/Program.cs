namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--ques1--");
            //creating a instance of car class
            Car car = new Car();
            //setting the properties
            car.Name = "BMW";
            car.Model = "unknown";
            car.Year = 2000;
            //calling the method
            car.Start();
            car.carInfo(car.Name,car.Model,car.Year);

            Console.WriteLine("");
            Console.WriteLine("--ques2--");
            Calculation cal = new Calculation();
            cal.calc();
            cal.calc(2, 3);
            cal.calc(2.3, 1.2);
            int mul = cal.calc(1, 2, 3);
            Console.WriteLine("mul is " + mul);

            Console.ReadKey();

        }
    }
}
