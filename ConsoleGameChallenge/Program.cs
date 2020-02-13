using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramUI.DisplayDirections();

            string answerKey = "";
            string answer = "_ _ D _   B _ _ A _ _ _";
            char[] answerArray = answer.ToCharArray();
            while (answerKey != "C O D E   B R E A K E R")
            {
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "c" || userInput == "o" || userInput == "e" || userInput == "r" || userInput == "k")
                {
                    switch (userInput)
                    {
                        case "c":
                            Console.WriteLine("That is correct!");
                            answerArray[0] = 'C';
                            Console.WriteLine(new string(answerArray));
                            break;
                        case "o":
                            Console.WriteLine("That is correct!");
                            answerArray[2] = 'O';
                            Console.WriteLine(new string(answerArray));
                            break;
                        case "e":
                            Console.WriteLine("That is correct!");
                            answerArray[6] = 'E';
                            answerArray[14] = 'E';
                            answerArray[20] = 'E';
                            Console.WriteLine(new string(answerArray));
                            break;
                        case "k":
                            Console.WriteLine("That is correct!");
                            answerArray[18] = 'K';
                            Console.WriteLine(new string(answerArray));
                            break;
                        case "r":
                            Console.WriteLine("That is correct!");
                            answerArray[12] = 'R';
                            answerArray[22] = 'R';
                            Console.WriteLine(new string(answerArray));
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("That is incorrect. Please try again!");
                }
                answerKey = new string(answerArray);
            }
            Console.WriteLine("Congrats! You got it!");
            Console.ReadLine();
        }
    }
}
