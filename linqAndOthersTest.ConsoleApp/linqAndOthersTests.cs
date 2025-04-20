﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNSDotNetTrainingBatch1.ConsoleApp
{
    internal class linqAndOthersTests
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            var evenNumbers = numbers.Where(nums => nums % 2 == 0);

            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}