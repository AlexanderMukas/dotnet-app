using System;

namespace ConsoleApp1
{
    class Program
    {
        static double SumTwoNum(double one, double two)
        {
            return one + two;
        }
        static void Main(string[] args)
        {
            double x = 23.73;
            double y = 37.27;
            Console.WriteLine("Hello World, Alexander!");
            Console.WriteLine("SumTwoNum of ", x.ToString(), "and ", y.ToString(), "= ", SumTwoNum(x,y));
        }
    }
}
