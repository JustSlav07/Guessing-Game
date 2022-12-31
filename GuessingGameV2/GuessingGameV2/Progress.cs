using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGameV2
{
    class Progress
    {
        public static int lvlCap = QuestionAssets.answers.GetLength(0);
        public static int lvlAccess = 0;
        public static int lvl = 0;
        public static int questionCap = QuestionAssets.answers.GetLength(1);
    }
}
