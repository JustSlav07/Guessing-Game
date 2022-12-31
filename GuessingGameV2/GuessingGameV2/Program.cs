using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GuessingGameV2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (!Actions.endProgram)
            {
                Default.SetToDefault();

                Console.Write("Enter a command: ");
                Commands.userCommand = Console.ReadLine();
                Console.Clear();

                if(Commands.userCommand == Commands.startGame)
                {
                    while(!Actions.endSellect)
                    {
                        Actions.SellectLvl();
                    }

                    for (int i = 0; i < Progress.questionCap && !Result.lose; i++)
                    {
                        QuestionAssets.AskQuestion(i);

                        if (QuestionAssets.guess[Progress.lvl, i] == QuestionAssets.answers[Progress.lvl, i])
                        {
                            Result.Correct(i);
                        }
                        else
                        {
                            Result.Wrong();
                        }

                        if (Result.mistakes == 3)
                        {
                            Result.lose = true;
                        }
                    }
                    Score.GetBonus();
                    Score.SetBest();

                    Console.WriteLine(Result.ReturnResult());

                    if (Progress.lvlAccess < Progress.lvlCap && !Result.lose)
                    {
                        Progress.lvlAccess++;
                    }

                    Console.WriteLine(Result.press);
                    Console.ReadKey();
                    Console.Clear();
                }
                else if(Commands.userCommand == Commands.shutDown)
                {
                    Actions.ShutDown();
                }
                else if(Commands.userCommand == Commands.listCommand)
                {
                    Actions.ListCommands();
                }
                else if(Commands.userCommand == Commands.showScore)
                {
                    Actions.ShowScore();
                }
                else if(Commands.userCommand == Commands.lvlAccess)
                {
                    Actions.LvlAccess();
                }
                else
                {
                    Actions.Correct();
                }
            }
        }
    }
}
