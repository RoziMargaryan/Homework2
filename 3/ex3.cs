//write a function that takes in a list of integers and returns the largest integer in the list.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class ex3
    {
        static int findTheLargestInteger(List<int> list)
        {
            int largestNumber = list[0];

            foreach (int i in list)
            {
                if (i > largestNumber)
                {
                    largestNumber = i;
                }
            }

            return largestNumber;
        }

        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 65, 43, 12, 3 };

            int largestNumber=findTheLargestInteger(list);
            Console.WriteLine($"The largest number is {largestNumber}");

        }
    }
}