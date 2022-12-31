using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGameV2
{
    static class QuestionAssets
    {
        public static string[,] answers =
        {
            { "7", "Asia", "Everest", "Russia", "China", "Rabat"},
            { "2", "9 months", "5", "The Brain", "They consume CO^2 and then release 0^2", "Yes" },
            { "8", "The Milky Way", "Yes", "No", "4.2 light years", "No" }
        };
        public static string[,] guess = new string[ 3, 6 ];
        public static string[,] questions =
        {
            {
                "How many continents are there on our planet?",
                "What's the name of the biggest continent on our planet?",
                "What's the name of the tallest mountain in our world?",
                "What's the name of the biggest country?",
                "What's the most populated country in the world?",
                "What's the name of the capital of Maroko?"
            },
            { 
                "How many genders are there?", 
                "How much time does a baby sit in her mom's belly?", 
                "How many human senses do we have?", 
                "What is the most important organ that you have?", 
                "What do plants do for us?", 
                "Are viruses alive?" 
            },
            { 
                "How many planets are there in our solar sistem?", 
                "What is the name of our galaxy?", 
                "Are black holes dangerous?", 
                "Is it possible for something to travel at the speed of light?",
                "How many light years away is the closest solar system from us?", 
                "Are we the only inteligent specie in space?" 
            }
        };

        public static string enter = "Enter your answer: ";

        public static void AskQuestion(int q)
        {
            Console.WriteLine(questions[Progress.lvl, q]);
            Console.Write(enter);
            guess[Progress.lvl, q] = Console.ReadLine();
            
            Console.Clear();
        }
    }
}
