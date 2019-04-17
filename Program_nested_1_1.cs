using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nested_q1_1
    //user can input no of time to print *
{
    class Program
    {
        static void Main(string[] args)
        {
            int userinput;
            int rowCounter
                , colum, rows, textCounter;
            // get input from user no of row
            Console.Write("How many rows of * you want to create :");
            userinput = int.Parse(Console.ReadLine());
            rows = userinput;
            colum = rows;

            rowCounter = 1;
            while (rowCounter <= rows)
            {
                textCounter = colum;
                while (textCounter >= 1)
                {
                    Console.Write("*");
                    textCounter = textCounter - 1;
                }
                Console.Write("\n");
                colum = colum - 1;
                rowCounter = rowCounter + 1;
            }
            Console.ReadLine();




        }
    }
}
