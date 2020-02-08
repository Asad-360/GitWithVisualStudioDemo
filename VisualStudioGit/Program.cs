using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudioGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to visual studio");
            PrintNumbers();
        }
        static void PrintNumbers()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void PrintEventNumbers()
        {
            for(int i=0 ; i < 20 ; i++)
            {
                if(i % 2 == 0)
                    Console.WriteLine(i);
            }
            
        }
        static void PrintOddNumbers()
        {
            for (int i = 0; i < 20 ; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
