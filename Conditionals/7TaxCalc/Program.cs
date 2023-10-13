using System.Runtime.InteropServices;

namespace _7TaxCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your yearly income");
            int income = int.Parse(Console.ReadLine());
            if (income > 150000)
            {
                Console.WriteLine("you will pay £" + (income * 0.45)+" in tax");
            }else if (income > 50270)
            {
                Console.WriteLine("you will pay £" + (income * 0.4) + " in tax");
            }else if(income>12570)
            {
                Console.WriteLine("you will pay £" + (income * 0.2) + " in tax");
            }
            else
            {
                Console.WriteLine("You will pay no tax");
            }
        }
    }
}