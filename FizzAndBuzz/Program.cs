﻿using System;
using System.Collections.Generic;

namespace FizzAndBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberProcess.ShowFizzBuzzNumbers(0));
            Console.ReadKey();
        }
    }



    public class NumberProcess
    {
        public static string ShowFizzBuzzNumbers(int maxNumber)
        {
            if (maxNumber <= 0)
            {
                return "the input number must be larger than zero.";
            }
            List<string> numberStrs = new List<string>();
            for (int i = 1; i <= maxNumber; i++)
            {
                string numStr = i.ToString();
               
                if (i % 3 == 0 || numStr.Contains("3"))
                {
                    numStr = "Fizz";
                    numberStrs.Add(numStr);
                    continue;
                }
                if (i % 5 == 0 || numStr.Contains("5"))
                {
                    numStr = "FizzBuzz";
                    numberStrs.Add(numStr);
                    continue;
                }
                if ((i % 3 == 0 && i % 5 == 0) || (numStr.Contains("3") && numStr.Contains("5")))
                {
                    numStr = "FizzBuzz";
                    numberStrs.Add(numStr);
                    continue;
                }
                numberStrs.Add(numStr);
            }
            return string.Join(" ", numberStrs);
        }
    }
}