using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.CSharp.Chapter3
{
    /// <summary>
    /// 3-2 p60
    /// </summary>
    class Program
    {
        static double TakeSquareRoot(int x)
        {
            return Math.Sqrt(x);
        }
        static void Main(string[] args)
        {
            List<int> integers = new List<int> {1, 2, 3, 4};

            Converter<int, double> converter = TakeSquareRoot;
            List<double> doubles = integers.ConvertAll<double>(converter);

            foreach (double d in doubles)
            {
                Console.WriteLine(d);
            }
        }
    }
}
