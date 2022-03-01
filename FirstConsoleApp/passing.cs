using System;

//----------------------------Passing by Value-------------------------------

//namespace FirstConsoleApp
//{
//    class passing
//    {
//        void doSwap(int x, int y)
//        {
//            int temp;
//            temp = x;
//            x = y;
//            y = temp;
//            Console.WriteLine("After swapping in method: x = {0}, y = {1}",x,y);
//        }
//        static void Main(string[] args)
//        {
//            passing n = new passing();
//            int a = 1;
//            int b = 2;

//            Console.WriteLine("Before swapping: a = {0}, b = {1}", a, b);
//            n.doSwap(a,b);
//            Console.WriteLine("After swapping: a = {0}, b = {1}", a, b);
//            Console.ReadLine();
//        }
//    }
//}

//----------------------------Passing by Reference-------------------------------
//namespace FirstConsoleApp
//{
//    class passing
//    {
//        void doSwap(ref int x, ref int y)
//        {
//            int temp;
//            temp = x;
//            x = y;
//            y = temp;
//        }
//        static void Main(string[] args)
//        {
//            passing n = new passing();
//            int a = 1;
//            int b = 2;

//            Console.WriteLine("Before swapping: a = {0}, b = {1}", a, b);
//            n.doSwap(ref a, ref b);
//            Console.WriteLine("After swapping: a = {0}, b = {1}", a, b);
//            Console.ReadLine();
//        }
//    }
//}


//----------------------------Passing by Out-------------------------------
//namespace FirstConsoleApp
//{
//    class passing
//    {
//        void getValues(out int x, out int y)
//        {
//            x = 10;
//            y = 20;
//        }
//        static void Main(string[] args)
//        {
//            passing n = new passing();
//            int a = 1;
//            int b = 2;

//            Console.WriteLine("Before passing in method: a = {0}, b = {1}", a, b);
//            n.getValues(out a, out b);
//            Console.WriteLine("After passing in method: a = {0}, b = {1}", a, b);
//            Console.ReadLine();
//        }
//    }
//}


