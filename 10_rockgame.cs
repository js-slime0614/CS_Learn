using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021GSMCSConsole.소스코드
{
    
    class _10_rockgame
    {   
        enum Choise
        {
            SCISSORS = 0,
            PAPER = 1,
            ROCK = 2
        };
        static void Play(string player)
        {
            Random rand = new Random();
            int aiChoice = rand.Next(0, 3);
            // 0 = 가위, 1 = 보, 2 = 바위
            
            switch(player)
            {
                case "바위":
                case "주먹":
                case "rock":
                    if(aiChoice == (int)Choise.SCISSORS) {
                        Console.WriteLine("컴퓨터 : 가위, 플레이어 : 주먹\n 플레이어 승!!");
                    } else if(aiChoice == (int)Choise.PAPER) {
                        Console.WriteLine("컴퓨터 : 보, 플레이어 : 주먹\n 컴퓨터 승!!");
                    } else {
                        Console.WriteLine("컴퓨터 : 주먹, 플레이어 : 주먹\n 무승부");
                    }
                    break;
                case "가위":
                case "가비":
                case "scissors":
                    if (aiChoice == (int)Choise.SCISSORS)  {
                        Console.WriteLine("컴퓨터 : 가위, 플레이어 : 가위\n 무승부");
                    } else if (aiChoice == (int)Choise.PAPER) {
                        Console.WriteLine("컴퓨터 : 보, 플레이어 : 가위\n 플레이어 승!!");
                    } else {
                        Console.WriteLine("컴퓨터 : 주먹, 플레이어 : 가위\n 컴퓨터 승!!");
                    }
                    break;
                case "보":
                case "보자기":
                case "paper":
                    if (aiChoice == (int)Choise.SCISSORS) {
                        Console.WriteLine("컴퓨터 : 가위, 플레이어 : 보\n 컴퓨터 승!!");
                    } else if (aiChoice == (int)Choise.PAPER) {
                        Console.WriteLine("컴퓨터 : 보, 플레이어 : 보\n 무승부");
                    } else {
                        Console.WriteLine("컴퓨터 : 주먹, 플레이어 : 보\n 플레이어 승!!");
                    }
                    break;
                default:
                    Console.WriteLine("가위 바위 보 라닌까");
                    break;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("가위 바위 보 ! : ");
            string Players = Console.ReadLine();
            _10_rockgame.Play(Players);
        }
    }
}
