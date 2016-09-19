using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_Of_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5 };

            try
            {
                for (int i = 0; i <= 10; i++)
                {
                    int num = myArray[i];
                    Console.WriteLine(num);
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Now you have gone out of range!");
            }
        }
    }
}

