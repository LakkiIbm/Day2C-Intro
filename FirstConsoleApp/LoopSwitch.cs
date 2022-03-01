using System;

namespace FirstConsoleApp
{
    internal class LoopSwitch
    {
        static void Main(string[] args)
        {
            //Program to display sum of first n natural numbers
            int n,sum;
            Console.Write("Enter the number: ");
            n=int.Parse(Console.ReadLine());
            sum = 0;
            for(int i=1; i<=n; i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum of first {0} natural numbers is : {1}", n, sum);
            Console.ReadLine();
        }

    }
}
