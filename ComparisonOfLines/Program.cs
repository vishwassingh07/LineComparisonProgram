using System;
namespace ComparisonOfLines
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Line Comparison Program.....");
            //LineComparison length = new LineComparison(2,5,4,9);
            //length.CalculatingLength();

            LineComparison equating = new LineComparison(1, 4, 6, 8);
            double line1 = equating.CalculatingLength();
            LineComparison equating2 = new LineComparison(2, 5, 3, 8);
            double line2 = equating2.CalculatingLength();

            if (line1.Equals(line2))
            {
                Console.WriteLine("Both the Lines are equal");
            }
            else
            {
                Console.WriteLine("Both the Lines are not equal");
            }
        }
    }
}