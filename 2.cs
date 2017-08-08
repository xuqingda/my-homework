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
            int n = 6;
            int[] a = new int[6] { 1, 1, 2, 2, 3, 4 };

            int j = 0;
            int i = 0;
            for (i = 1; i < n; i++)
            {
                
                if (a[j] != a[i])
                {
                   
                    a[++j] = a[i];
                    

                }

            }

            Console.WriteLine(j+1);

            Console.ReadKey();
        }

    }

}

