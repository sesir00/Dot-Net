using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//here one class inherits another class and such class inturns gets inherited by another class
//A<-B<-C
namespace NCCS
{
    class FourWheeler
    {
        private int reg;
        private string brand;
        private string type;
        //properties
        public int Reg
        {

            get { return reg; }
            set { reg = value; }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }

        }

    }
    class Car : FourWheeler
    {
        private int horsepower;
        public int Horsepower
        {
            get { return horsepower; }
            set { horsepower = value; }
        }

    }
    class Electriccar : Car
    {
        private int range;
        public int Range
        {
            get { return range; }
            set { range = value; }
        }
    }
}
