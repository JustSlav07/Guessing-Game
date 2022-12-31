using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGameV2
{
    static class Result
    {
        public static string press = "Press Enter to continue.";
        public static string correct = "Correct!";
        public static string wrong = "Wrong!";
        public static int mistakes = 0;
        public static bool lose = false;

        public static void Wrong()
        {
            Console.WriteLine(wrong);

            mistakes++;

            Console.WriteLine(press);
            Console.ReadKey();
            Console.Clear();
        }
        public static void Correct(int p) 
        {
            Console.WriteLine(correct);

            Score.lvlScore[Progress.lvl] += Score.questionPoints[p];

            Console.WriteLine(press);
            Console.ReadKey();
            Console.Clear();
        }

        public static string ReturnResult()
        {
            if (lose)
            {
                return "You Lost!";
            }
            else if (Progress.lvl + 1 == Progress.lvlCap && !lose)
            {
                return "You beat the game!";
            }
            else
            {
                return "You Won!";

            }
        }
    }
}
