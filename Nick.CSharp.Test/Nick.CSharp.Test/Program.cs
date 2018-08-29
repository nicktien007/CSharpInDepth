using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.CSharp.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //代碼2-5 p46
            //Func<int, int, string> func = (x, y) => (x * y).ToString();
            //Console.WriteLine(func(5,20));

            var a = new {Name = "a", Age = 29};
            var b = new {Name = "b", Age = 88};

            var c = new { Name = "b", Age = 88,Height=178 };
            
            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());
            Console.WriteLine(c.GetType());
        }
    }
}
