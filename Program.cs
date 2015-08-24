//Please note: This application is purely for my own education, to run through coding 
//examples by following tutorials, and to just tinker around with coding.  
//I know it’s bad practice to heavily comment code (code smell), but comments in all of my 
//exercises will largely be left intact as this serves me 2 purposes:
//    I want to retain what my original thought process was at the time
//    I want to be able to look back in 1..5..10 years to see how far I’ve come
//    And I enjoy commenting on things, however redundant this may be . . .

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Magic8Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor oldColor = Console.ForegroundColor;

            TellPeopleWhatProgramThisIs();

            Random randomObject = new Random();

            while (true)
            {
                string questionString = GetQuestionFromUser();

                if (questionString.Length == 0)
                {
                    Console.WriteLine("You need to ask a question!");
                    continue;
                }

                int numberOfSecondsToSleep = randomObject.Next(5) + 1;
                Console.WriteLine("Hmm... Let's see...");
                Thread.Sleep(numberOfSecondsToSleep * 1000);

                if (questionString.ToLower() == "you suck")
                {
                    Console.WriteLine("Hmm.. whatever! Bye!");
                    break;
                }

                if (questionString.ToLower() == "quit")
                {
                    break;
                }

                int randomNumber = randomObject.Next(4);

                Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);

                switch (randomNumber)
                {
                    case 0:
                        {
                            Console.WriteLine("YES!");
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("NO!");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("HELL NO!");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("OMG YES!");
                            break;
                        }
                }
            }

            Console.ForegroundColor = oldColor;
        }

        static void TellPeopleWhatProgramThisIs()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("M");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("agic 8 Ball");
        }

        static string GetQuestionFromUser()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Ask a question?: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            string questionString = Console.ReadLine();

            return questionString;
        }
    }
}
