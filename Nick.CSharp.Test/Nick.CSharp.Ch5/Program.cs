using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.CSharp.Ch5
{
    class Program
    {
        delegate Stream StreamFactory();

        static MemoryStream GererateSampleData()
        {
            byte[] buffer = new byte[16];
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = (byte) i;
            }

            return new MemoryStream(buffer);
        }
        static void Main(string[] args)
        {
            //5-3
            StreamFactory factory = GererateSampleData;

            using (Stream stream = factory())
            {
                int data;
                while ((data = stream.ReadByte())!=-1)
                {
                    Console.WriteLine(data);
                }
            }
        }
    }
}
