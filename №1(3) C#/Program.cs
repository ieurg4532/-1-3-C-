using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter xmin: ");
            double xmin = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter xmax: ");
            double xmax = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter dx: ");
            double dx = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter k: ");
            double k = Convert.ToDouble(Console.ReadLine());

            if (dx <= 0)
            {
                Console.WriteLine("Error: Step dx must be positive.");
                return;
            }

            if (xmin > xmax)
            {
                Console.WriteLine("Error: xmin must be less than or equal to xmax.");
                return;
            }

            if (a == 0)
            {
                Console.WriteLine("Error: a cannot be zero.");
                return;
            }

            Console.WriteLine(" x\t\tf(x)");

            for (double x = xmin; x <= xmax; x += dx)
            {
                if (a * x <= 0)
                {
                    Console.WriteLine($"{x:F2}\t\tCannot be calculated (ln)");
                    continue;
                }
                double cosValue = Math.Cos(a * x);
                double part1 = Math.Pow(cosValue, 1.0 / 3.0);
                double part2 = (k * cosValue) / Math.Log(a * x);

                double y = part1 + part2;

                Console.WriteLine($"{x:F2}\t\t{y:F4}");

            }
        }
    }
}