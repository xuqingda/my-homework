using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            //public int sort()
            //{

            //}
            //string numrows = Console.ReadLine();
            Console.WriteLine("tell me how many rows will you want in Pascal's triangle:");
            int numrows= Convert.ToInt32(Console.ReadLine());
            
            int [,] a = new int[numrows, numrows];
            //Console.WriteLine(i.ToString());
            for (int i = 0; i < numrows; i++)
            {
                a[i, 0] = 1;
                a[i, i] = 1;

                for (int j = 1; j < i; j++)
                {
                    a[i, j] = a[i - 1, j - 1] + a[i - 1, j];



                    Console.WriteLine(a[i, j]);
                }
            }

       




        //Console.WriteLine(numrows.ToString());

        Console.ReadKey();
        }

    }

}