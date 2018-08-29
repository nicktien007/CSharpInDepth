using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.CSharp.Chapter3
{
    class Program
    {
        static double TakeSquareRoot(int x)
        {
            return Math.Sqrt(x);
        }

        static bool AreReferencesEqual<T>(T first, T second) where T :class 
        {
            return first == second;
        }
        static void Main(string[] args)
        {
            //3-2 p60
            //List<int> integers = new List<int> {1, 2, 3, 4};

            //Converter<int, double> converter = TakeSquareRoot;
            //List<double> doubles = integers.ConvertAll<double>(converter);

            //foreach (double d in doubles)
            //{
            //    Console.WriteLine(d);
            //}

            //3-5 p70
            string name = "Jon";
            string intro1 = "My Name is " + name;
            string intro2 = "My Name is " + name;
            Console.WriteLine(intro2==intro1);
            Console.WriteLine(AreReferencesEqual(intro1,intro2));

        }
    }
}
