using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGameV2
{
    class Actions
    {
        public static bool endSellect = false;
        public static bool endProgram = false;

        public static void ListCommands()
        {
            Console.WriteLine(Commands.startGame);
            Console.WriteLine(Commands.showScore);
            Console.WriteLine(Commands.lvlAccess);
            Console.WriteLine(Commands.shutDown);
            Console.WriteLine(Result.press);
            Console.ReadKey();
            Console.Clear();
        }
        public static void ShowScore()
        {
            Console.WriteLine("Your level 1 score is " + Score.bestScore[0] + " points.");
            Console.WriteLine("Your level 2 score is " + Score.bestScore[1] + " points.");
            Console.WriteLine("Your level 3 score is " + Score.bestScore[2] + " points.");
            Console.WriteLine("Your overal score is " + Score.bestScore[0] + " points.");

            Console.WriteLine(Result.press);
            Console.ReadKey();
            Console.Clear();
        }
        public static void LvlAccess()
        {
            if (Progress.lvlAccess == 0)
            {
                Console.WriteLine("You can access level 1.");
            }
            else if (Progress.lvlAccess == 1)
            {
                Console.WriteLine("You can access level 1 and 2.");
            }
            else if (Progress.lvlAccess == 2)
            {
                Console.WriteLine("You can access level 1, 2 and 3.");
            }

            Console.WriteLine(Result.press);
            Console.ReadKey();
            Console.Clear();
        }
        public static void SellectLvl()
        {
            Console.Write("Sellect a level: ");
            Progress.lvl = Convert.ToInt16(Console.ReadLine()) - 1;

            if (Progress.lvl <= Progress.lvlAccess)
            {
                endSellect = true;
            }
            else if (Progress.lvl > Progress.lvlAccess && Progress.lvl < Progress.lvlCap)
            {
                Console.WriteLine("This level is still not reached!");
                Console.WriteLine(Result.press);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Invalid level!");
                Console.WriteLine(Result.press);
                Console.ReadKey();
            }

            Console.Clear();
        }
        public static void ShutDown()
        {
            endProgram = true;
        }
        public static void Correct()
        {
            Console.WriteLine("Invalid Command!");
            Console.WriteLine("To list all commands type: " + Commands.listCommand);
            Console.WriteLine(Result.press);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
