using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i=0; i<n+1; i++)
            {
                for(int j=0; j<i; j++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }
        }
    }
}
