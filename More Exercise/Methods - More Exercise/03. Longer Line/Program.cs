using System;

namespace _03._Longer_Line
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double line1 = GetDistanceBetweenTwoPoints(x1, y1, x2, y2);
            double line2 = GetDistanceBetweenTwoPoints(x3, y3, x4, y4);

            // if the first point (from the piar) is closer to zero = true
            bool line1Point1IsCloserToZero = aPointCloserToTheZero(x1, y1, x2, y2);
            bool line2Point1IsCloserToZero = aPointCloserToTheZero(x3, y3, x4, y4);

            if (line1 >= line2)
            {
                if (line1Point1IsCloserToZero)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                if (line2Point1IsCloserToZero)
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }

        }

        private static double GetDistanceBetweenTwoPoints(double x1, double y1, double x2, double y2)
        {
            double sideA = Math.Abs(x2 - x1);
            double sideB = Math.Abs(y2 - y1);

            double sideC = Math.Sqrt((sideA * sideA) + (sideB * sideB));

            return sideC;
        }

        private static bool aPointCloserToTheZero(double x1, double y1, double x2, double y2)
        {
            double c1 = GetHypotenuse(x1, y1);
            double c2 = GetHypotenuse(x2, y2);

            bool result = true;

            if (c2 < c1)
            {
                result = false;
            }

            return result;
        }

        private static double GetHypotenuse(double a, double b)
        {
            double c = Math.Sqrt((a * a) + (b * b));

            return c;
        }
    }
}
