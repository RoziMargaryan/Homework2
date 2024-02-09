using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2
{
    internal class ex2
    {

        static List<T> findMiddleElements<T>(List<T> list)
        {
            List<T> result = new List<T>();

            int numberOfElements = list.Count;

            int middleIndex = numberOfElements / 2;

            if (numberOfElements % 2 == 0)
            {
                result.Add(list[middleIndex - 1]);
                result.Add(list[middleIndex]);
            }
            else
            {
                result.Add(list[middleIndex]);
            }

            return result;

        }
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1,2,3,4,5};

            var result=findMiddleElements(list);

            if(result.Count == 1)
            {
                Console.WriteLine("Middle element is {0}", result[0]);
            }
            else
            {
                Console.WriteLine("Middle element(s): {0},{1}", result[0], result[1]);
            }
            
        }
    }
}
