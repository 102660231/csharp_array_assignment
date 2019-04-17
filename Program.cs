using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challeng_nested.cs
{
    class Program
    {
        static void Main(string[] args)
        {

            int linelength;
     //       int spacecount;
       //     spacecount = 0;

            int row;
            int colum;
            row = 0;
            linelength = 11;

            while (row <= 6) 
            {

                
                colum = 1;
                while (colum <= linelength) 
                {
                    Console.Write("*");
                    colum++;


                }
                Console.Write("\n");

                linelength = linelength - 2;


                Console.Write(" ");

                row = row + 1;
                if (row ==2)
                {

                    Console.Write(" ");

                }
                
                if (row == 3)
                {
                    Console.Write("  ");
                }
                if(row == 4)
                {
                    Console.Write("   ");
                }
                if (row == 5)
                {
                    Console.Write("    ");
                }
                
            }
            Console.ReadKey();
        }

    }
}
