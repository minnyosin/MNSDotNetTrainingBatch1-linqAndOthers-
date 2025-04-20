using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MNSDotNetTrainingBatch1.ConsoleApp
{
    internal class linqAndOthersTests
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            string[] names = {};
            decimal[] points = {};

            var evenNumbers = numbers.Where(nums => nums % 2 == 0).ToArray();
            var twoTimes = numbers.Select(nums => nums * 2).ToArray();
            var ascendingOrder = numbers.OrderBy(nums => nums).ToArray();
            var descendingOrder = numbers.OrderByDescending(nums => nums).ToArray();
            var firstElement = numbers.First();
            var firstOrDefault_int = numbers.FirstOrDefault(nums => nums > 5);
            var firstOrDefault_string = names.FirstOrDefault();
            var firstOrDefault_decimal = points.FirstOrDefault();
            var sum = numbers.Sum();
            var max = numbers.Max();
            var min = numbers.Min();
            var average = numbers.Average();
            var count = numbers.Count();

            Console.Write("Even Numbers: ");
            for (var i = 0; i < evenNumbers.Length; i++)
            {
                Console.Write(evenNumbers[i]);
                if (i <  evenNumbers.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine('\n');

            Console.Write("Multiply with Two: ");
            for (var i = 0; i < twoTimes.Length; i++)
            {
                Console.Write(twoTimes[i]);
                if (i < twoTimes.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine('\n');

            Console.Write("Ascending Order: ");
            for (var i = 0; i < ascendingOrder.Length; i++)
            {
                Console.Write(ascendingOrder[i]);
                if (i < ascendingOrder.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine('\n');

            Console.Write("Descending Order: ");
            for (var i = 0; i < descendingOrder.Length; i++)
            {
                Console.Write(descendingOrder[i]);
                if (i < descendingOrder.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine('\n');

            Console.Write($"First Element: {firstElement}");
            Console.WriteLine('\n');

            Console.Write($"Default Element of int: {firstOrDefault_int}");
            Console.WriteLine('\n');

            Console.Write($"Default Element of string: {firstOrDefault_string}");
            Console.WriteLine('\n');

            Console.Write($"Default Element of decimal: {firstOrDefault_decimal}");
            Console.WriteLine('\n');

            Console.Write($"Sum of the Numbers: {sum}");
            Console.WriteLine('\n');

            Console.Write($"Maximum value of the Numbers: {max}");
            Console.WriteLine('\n');

            Console.Write($"Minimum value of the Numbers: {min}");
            Console.WriteLine('\n');

            Console.Write($"Avarage of the Numbers: {average}");
            Console.WriteLine('\n');

            Console.Write($"Number count: {count}");
            Console.WriteLine('\n');














        }
    }
}