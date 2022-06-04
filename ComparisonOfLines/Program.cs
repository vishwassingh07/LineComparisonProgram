using System;
namespace ComparisonOfLines
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Line Comparison Program.....");
            LineComparison length = new LineComparison(2,5,4,9);
            length.CalculatingLength();
        }
    }
}