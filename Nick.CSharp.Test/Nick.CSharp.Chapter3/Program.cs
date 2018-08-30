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

        /// <summary>
        /// 3-6 P71
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        public sealed class Pair<T1, T2> : IEquatable<Pair<T1, T2>>
        {
            private static readonly IEqualityComparer<T1> FirstComparer = EqualityComparer<T1>.Default;
            private static readonly IEqualityComparer<T2> SecondComparer = EqualityComparer<T2>.Default;

            private readonly T1 _first;
            private readonly T2 _second;

            public Pair(T1 first,T2 second)
            {
                this._first = first;
                this._second = second;
            }

            public T1 First
            {
                get { return _first; }
            }

            public T2 Second
            {
                get { return _second; }
            }

            /// <summary>
            /// 複寫EqualityComparer.Equals
            /// </summary>
            /// <param name="other"></param>
            /// <returns></returns>
            public bool Equals(Pair<T1, T2> other)
            {
                return other != null &&
                       FirstComparer.Equals(this.First, other.First) &&
                       SecondComparer.Equals(this.Second, other.Second);
            }
            
            public override bool Equals(object o)
            {
                return Equals(o as Pair<T1, T2>);
            }

            public override int GetHashCode()
            {
                return FirstComparer.GetHashCode(_first) * 37 +
                       SecondComparer.GetHashCode(_second);
            }

            
        }
        /// <summary>
        /// 3-7
        /// </summary>
        public static class Pair
        {
            public static Pair<T1, T2> Of<T1, T2>(T1 first, T2 second)
            {
                return new Pair<T1, T2>(first, second);
            }
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
            //string name = "Jon";
            //string intro1 = "My Name is " + name;
            //string intro2 = "My Name is " + name;
            //Console.WriteLine(intro2==intro1);
            //Console.WriteLine(AreReferencesEqual(intro1,intro2));



            //3-6
            //Pair<int, string> pair1 = new Pair<int, string>(10, "value");
            //Pair<int, string> pair2 = new Pair<int, string>(10, "value");

            //3-7，更好的用法
            Pair<int, string> pair3 = Pair.Of(10, "value");
            Pair<int, string> pair4 = Pair.Of(10, "value");


            //var result = pair1.Equals(pair2);
            var result = pair3.Equals(pair4);
            Console.WriteLine(result);

        }
    }
}
