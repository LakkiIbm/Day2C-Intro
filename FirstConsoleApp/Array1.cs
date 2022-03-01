using System;
using System.Linq;

//------------------------------1D Array and its features-----------------------------
//namespace FirstConsoleApp
//{
//    class Array1
//    {
//        static void Main(string[] args)
//        {
//            string[] fruits = { "Lichi", "Guava", "Apple", "Grapes", "Mango" };
//            Console.WriteLine("Number of fruits I like: " + fruits.Length);
//            Console.WriteLine("Names of the fruits:");
//            foreach (string fruit in fruits)
//            {
//                Console.WriteLine(fruit);
//            }
//            Array.Sort(fruits);
//            Console.WriteLine("Names of the fruits in alphabetical order:");
//            foreach (string fruit in fruits)
//            {
//                Console.WriteLine(fruit);
//            }

//            int[] nos = { 4, 6, 1, 3, 10, 2 };
//            Console.WriteLine("No. of integers in the array: " + nos.Length);
//            foreach (int i in nos)
//                Console.WriteLine(i);
//            Console.WriteLine("Maximum integer in the array: " + nos.Max());
//            Console.WriteLine("Minimum integer in the array: " + nos.Min());
//            Console.WriteLine("Sum of integers in the array: " + nos.Sum());
//            Console.ReadLine();
//        }
//    }
//}


//------------------------------2D Array and its features-----------------------------
namespace FirstConsoleApp
{
    class Array1
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3,2]{ {4, 6 }, { 1, 3 }, { 10, 2 } };

            Console.WriteLine("Total no. of integers in the array: " + arr.Length);
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 2; j++)
                    Console.WriteLine("a[{0},{1}] = {2}",i,j,arr[i,j]);
            }
            Console.ReadLine();
        }
    }
}


