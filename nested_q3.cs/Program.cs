using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nested_q3.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 4;
            int nextline = 0;
            int line = 0;
            while (nextline <= rows)
            {
                line = 0;
                while (line <= nextline)
                {
                    Console.Write("*");
                    line++;
                }
                Console.WriteLine("\n");
                nextline++;
            }

            Console.ReadLine();

        }
    }
}
