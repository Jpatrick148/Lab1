using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1, num2, check;

            do //changed my while to a do while. I've tried to fix the while loop to close if the values IS NOT 1. But it still asks to restart the program.
            {
                Console.WriteLine("Please Enter 2 Numbers ");
                num1 = Console.ReadLine();
                num2 = Console.ReadLine();


                if (num1.Length == num2.Length)
                {
                    Console.WriteLine(TotalNumericString(num1, num2));

                }
                else

                {
                    Console.WriteLine("The numbers must be the same length. Try again.");
                }

                Console.WriteLine("Do you want to run this program again [Y/N] ?");
                check = Console.ReadLine().ToUpper();
                

                //

            } while (check == "Y");
        }
        public static bool TotalNumericString(string str1, string str2)
        {
            int total1, total2;
            for (int i = 0; i < str1.Length - 1; i++) // Minus 1 to string lengh to avoid going over numbers total lenght.
            {
                // Converts to Int32 and back to String. If not it tries to add the ASCII character values.
                total1 = Convert.ToInt32(str1[i].ToString()) + Convert.ToInt32(str2[i].ToString());
                total2 = Convert.ToInt32(str1[i + 1].ToString()) + Convert.ToInt32(str2[i + 1].ToString());

                if (total1 != total2)
                {
                    return false;
                }

            }
            return true;
        }
    }
}
