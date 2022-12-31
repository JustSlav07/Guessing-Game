using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGameV2
{
    internal class Score
    {
        public static int[] questionPoints = {1, 2, 3, 5, 7, 10};
        public static int[] bestScore = new int[3];
        public static int[] lvlScore = new int[3];

        public static int bonusPoints = 2;
        public static int overalScore = 0;

        public static void GetBonus()
        {
            if(Result.mistakes == Default.mistakes)
            {
                lvlScore[Progress.lvl] += bonusPoints;
            }
        }
        public static void SetBest()
        {
            if (lvlScore[Progress.lvl] > bestScore[Progress.lvl])
            {
                bestScore[Progress.lvl] = lvlScore[Progress.lvl];
            }
        }
        public static void SetOveral()
        {
            overalScore = bestScore[0] + bestScore[1] + bestScore[2];
            if(overalScore == 90)
            {
                overalScore = 100;
            }
        }
    }
}
