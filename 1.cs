using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int i;
            int j=0;

           // int e;
            //int n = 100000;
            int[] arry1 = new int[6] { 1, 2, 2, 3, 4, 5}; 

            for ( i=0 ; i<6; i++)
            {
                if (arry1[i] == 2)
                {
                    i++;
                }
                arry1[j] = arry1[i];
                j++;
                
            }
            Console.Write(j);
            Console.ReadKey();
        }

    }
}
