using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGameV2
{
    class Default
    {
        public static string[,] guess = QuestionAssets.guess;

        public static int[] lvlScore = Score.lvlScore;

        public static string userCommand = Commands.userCommand;
        public static int mistakes = Result.mistakes;
        public static bool lose = Result.lose;
        public static bool endSellect = Actions.endSellect;

        public static void SetToDefault()
        {
            QuestionAssets.guess = guess;
            Score.lvlScore = lvlScore;
            Commands.userCommand = userCommand;
            Result.mistakes = mistakes;
            Result.lose = lose;
            Actions.endSellect = endSellect;
        }
    }
}
