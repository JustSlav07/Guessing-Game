using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGameV2
{
    class Commands
    {
        public static char commandOp = '/';
        public static string userCommand = "";
        public static string listCommand = commandOp + "ListCommands";
        public static string showScore = commandOp + "ShowScore";
        public static string lvlAccess = commandOp + "LevelAccess";
        public static string startGame = commandOp + "StartGame";
        public static string shutDown = commandOp + "CloseProgram";
    }
}
