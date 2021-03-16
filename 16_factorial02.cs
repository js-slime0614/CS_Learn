using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021GSMCSConsole.소스코드
{
    class _16_factorial02
    {
        static int factorial(int num)
        {
            if (num == 0) {
                return 0;
            } 
            else if (num == 1) {
                return 1;
            } 
            else {
                return num * factorial(num - 1);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("몇 팩토리얼 ? : ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num}! = {factorial(num)}");
            //Console.WriteLine($"{num}! = {mul}");
        }
    }
}
