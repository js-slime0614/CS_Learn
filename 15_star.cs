using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021GSMCSConsole.소스코드
{
    class _15_star
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j< i + 1; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
        }
    }
}
