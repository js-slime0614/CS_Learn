using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021GSMCSConsole.소스코드
{
    class _14_gugudan
    {
        static void gugudan(int a)
        {
            for(int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine($"{a} * {b} = {a * b}");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("몇단? : ");
            int num1 = int.Parse(Console.ReadLine());
            _14_gugudan.gugudan(num1);
        }
    }
}
