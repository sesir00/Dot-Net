using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCCS
{
    class ArrayDemo
    {
        public void setArray()
        {
            //creating 1D array
            //direct initialization
            int[] arr1 = { 20, 30, 40, 50, 60 };
            //by mentioning size
            string[] arr2 = new string[5] { "Ram", "Shyam", "Hari", "Hero", "Rabin" };
            //arr2[0] = 5;
            Console.WriteLine("--displaying first array using for loop--");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i] + " , ");
            }
            Console.WriteLine("--displaying second array using for use loop--");
            foreach (string str in arr2)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("--Ex on 2D array--");
            int[,] arr3 =                   //bracket bitra comma dera 2D bako 
            {
                {2,3,4} ,           //oth row of array
                { 5,6,7} ,          //1th row of array
                { 8,9,10}           //2th row of array
            };
            Console.WriteLine("--displaying 2D array using for loop--");
            //getLength(0): return no. of row array
            //getLEngth(1): return no. of element in each row
            for (int i = 0; i < arr3.GetLength(0); i++)
            {
                for (int j = 0; j < arr3.GetLength(1); j++)
                {
                    Console.Write(arr3[i, j] + " ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("--using foreach loop for 2D--");
            foreach (int ans in arr3)
            {
                Console.WriteLine(ans);
            }
        }
        public void setJagged()
        {
            Console.WriteLine("--eg on jagged array--");
            //in 2d array if there are variation in number of columnn
            //i.e. 1st row contain 2 column ,2nd row contain 5 
            //by mentioning size
            string[][] ja = new string[3][];
            ja[0] = new string[] { "ram", "sam" }; //2 column
            ja[1] = new string[] { "sita", "rita", "gita" }; //3 column
            ja[2] = new string[] { "sarmila" }; //1 column

            for (int i = 0; i < ja.Length; i++)
            {
                for (int j = 0; j < ja[i].Length; j++)
                {
                    Console.WriteLine(ja[i][j] + " ");
                }
                Console.WriteLine("");
            }
            //using direct method 
            int[][] marks =
            {
                new int[] {1,2,3 },
                new int[] {4,5,6,7},
                new int[] {8,9}
            };
            foreach (int[] m in marks)
            {
                foreach (int m2 in m)
                {
                    Console.WriteLine(m2);
                }
            }
        }    


    }
}
