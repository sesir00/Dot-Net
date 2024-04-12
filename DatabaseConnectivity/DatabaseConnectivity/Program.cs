using System;


namespace DatabaseConnectivity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Insert i1 = new Insert();
            //i1.InsertOperation();
            //i1.dataInsert();
            i1.updateData();
            i1.deleteData();

            i1.dataFetch();
            
            Console.ReadKey();
        }
    }
}
