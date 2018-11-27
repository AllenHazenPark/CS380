using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Test_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter an Integer Value: ");
            string value = Console.ReadLine();
            int x = 0;

            try
            {
                 x = int.Parse(value);
            }
            catch (FormatException exception)
            {
                Console.WriteLine("Sorry, the value you entered was not valid!");

            }
            finally
            {
                string k = decToHex(x);
                Console.WriteLine();
                if (x.ToString("X") == k)
                {
                    Console.WriteLine("Validated. Algorithm works, results expected");
                }
                else
                {
                    Console.WriteLine("Invalid test. Algorithm does not work. ");
                }
            }

        }

        private static string decToHex(int n)
        {
            char[] hexDecNum = new char[100];
            int i = 0;
            while (n != 0)
            {
                int tempVal = 0;

                tempVal = n % 16;

                if (tempVal < 10)
                {
                    hexDecNum[i] = (char)(tempVal + 48);
                    i++;
                }
                else
                {
                    hexDecNum[i] = (char)(tempVal + 55);
                    i++;
                }

                n /= 16;
            }
            string k = "";
            for(int j = i - 1; j >= 0; j--)
            {
                Console.Write(hexDecNum[j]);
                k += hexDecNum[j];
            }
            return k;
        }
    }
}
