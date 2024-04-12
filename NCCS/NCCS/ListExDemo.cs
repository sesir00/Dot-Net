using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//List is used for collection of data. it use genric object that means it can take any type of data including object.
//to create list <> symbol is used
//syntax List <Object type> object name = new List<object type>();
namespace NCCS
{
    class ListExDemo
    {
        public void setList()
        {
            List<string> l1 = new List<string>() { "ram", "sam" ,"gita"};
            //adding new data in last position 
            l1.Add("hari");
            //finding out specified element
            var res1 = l1.Contains("sam");
            Console.WriteLine(res1);
            foreach (var val in l1)
            {
                Console.WriteLine(val);
            }
            //lambda expression like a method but doesnot have any type
            //uses=> symbol syntax: input=>expression or statement
            //it is used in collection like list and works as a method
            List <int>l2 = new List<int>() {  2, 4, 6, 8, 10, 11, 13};
            //using lambda expression to find out square of each element
            var sq = l2.Select(x => x * x);
            foreach (var v in sq)
            {
                Console.WriteLine(v); 
            }
            var f1 = l2.FindAll(x => (x % 2) == 0);
            foreach (var v in f1)
            {
                Console.WriteLine(v); 
            }
        }
    }
    //List in class
    class Labour
    {
        private int lid;
        private string name;
        private string workType;
        //properties
        public int Lid
        {
            get { return lid; }
            set { lid = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string WorkType
        {
            get { return workType; }
            set { workType = value; }
        }
    }
}
