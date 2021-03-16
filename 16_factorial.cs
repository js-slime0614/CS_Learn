using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021GSMCSConsole.소스코드
{
    class _16_factorial
    {
        static void Main(string[] args)
        {
            Console.Write("몇 팩토리얼 ? : ");
            int num = int.Parse(Console.ReadLine());
            int mul = 1;
            for(int i = 1; i <= num; i++)
            {
                mul *= i;
            }
            Console.WriteLine($"{num}! = {mul}");
        }
    }
}
