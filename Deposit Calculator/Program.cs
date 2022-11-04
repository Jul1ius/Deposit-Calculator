using System;

namespace Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            double months = double.Parse(Console.ReadLine()); 
            double percent = double.Parse(Console.ReadLine());

            double tottal = deposit + months * ((deposit * percent) /12);

            Console.WriteLine(tottal);
        }
    }
}
