using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GuessTheAnimal
{
    class Program
    {
        static BinaryTreeRoot Animals;
        static void Main(string[] args)
        {

            NewGame();

            Console.WriteLine("Let's begin!");

            Animals.Play();
        }

        static void NewGame()
        {

            Console.WriteLine("Loading....");

            Thread.Sleep(1000);
            ConsoleColor oldColor = Console.ForegroundColor;
            TellTheUserAboutTheGame();
            Console.ForegroundColor = oldColor;

            Console.WriteLine("Enter a question to guess Animal: ");
            string strQuestion = Console.ReadLine();

            Console.Write("Enter what you'd guess if Yes: ");
            string strYesSeed = Console.ReadLine();

            Console.Write("Enter a guess for No: ");
            string strNoSeed = Console.ReadLine();

            Animals = new BinaryTreeRoot(strQuestion, strYesSeed,
                strNoSeed);

        }

        static void TellTheUserAboutTheGame()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to the Guess the Animal Game"
                              + Environment.NewLine + "Please type in a question e.g. Does the animal bark?"
                              + Environment.NewLine + "If game doesn't guess, you win.");
        }
    }
}

