using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftRight = (n-1)/2;
            int mid = n - 2 * leftRight-2;

            for(int i=0; i<n; i++)
            {
                for(int j=0; j<n; j++)
                {                
                    Console.Write(new string('-', leftRight));
                    Console.Write("*");

                    if(mid>=0)
                    {
                        Console.Write(new string('-', mid));
                    }

                    Console.Write("*");
                    Console.Write(new string('-', leftRight));


                    if ((i <= n / 2 - 1 && n % 2 == 0) || (i <= n / 2 && n % 2 != 0))
                    {
                        leftRight--;
                    }
                    else
                    {
                        leftRight++;
                    }

                    Console.WriteLine();
                }
                
            }
        }
    }
}
