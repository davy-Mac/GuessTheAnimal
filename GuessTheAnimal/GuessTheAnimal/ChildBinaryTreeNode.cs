using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheAnimal
{
    [Serializable]
    class ChildBinaryTreeNode
    {
        string outputMessage;

        ChildBinaryTreeNode inputYes;
        ChildBinaryTreeNode inputNo;

        public ChildBinaryTreeNode(string strMessage)
        {
            outputMessage = strMessage;

            inputNo = null;
            inputYes = null;

        }
        public void Guess()
        {

            if (ValidQuestion())
            {
                Console.WriteLine(outputMessage);
                Console.Write("Enter 'Y' for YES and 'N' for NO: ");

                char chrInput = Answer();

                if (chrInput == 'y' || chrInput == 'Y')

                    inputYes.Guess();

                else if (chrInput == 'n' || chrInput == 'N')

                    inputNo.Guess();

            }
            else
                askMore();
        }
        public void askMore()
        {

            Console.WriteLine("Are you thinking of a(n) " + outputMessage +
               "?");

            Console.Write("Enter 'Y' for YES and 'N' for NO: ");

            char chrInput = Answer();

            if (chrInput == 'y')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Game Won...");
                Console.ReadLine();
            }
                

            else if (chrInput == 'n')
                Console.ForegroundColor = ConsoleColor.Yellow;
            PlayerWon();

        }
        private void PlayerWon()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("User wins! What Animal were you thinking of ? ");

            string strUserAnimal = Console.ReadLine();

            Console.Write("what's different betwen a " + outputMessage + " and " + strUserAnimal + ": ");

            string strQuestion = Console.ReadLine().ToLower();

            Console.Write("If thinking of a " + strUserAnimal + ", what would be the answer? ");
            char chrInput = Answer();

            if (chrInput == 'y')
            {
                inputNo = new ChildBinaryTreeNode(outputMessage);
                inputYes = new ChildBinaryTreeNode(strUserAnimal);
            }

            else if (chrInput == 'n')
            {
                inputYes = new ChildBinaryTreeNode(outputMessage);
                inputNo = new ChildBinaryTreeNode(strUserAnimal);
            }
            Console.Write("Stored in memory");
            StoreMessage(strQuestion);
        }

        public bool ValidQuestion()
        {
            if (inputNo == null && inputYes == null)
                return false;
            else
                return true;
        }

        private char Answer()
        {
            char chrInput = ' ';

            while (chrInput != 'y' && chrInput != 'n')
            {
                chrInput = Console.ReadLine().ElementAt(0);
                chrInput = Char.ToLower(chrInput);
            }
            return chrInput;
        }

        public void StoreMessage(string strMessage)
        {
            outputMessage = strMessage;
        }
        public string GetMessage()
        {
            return outputMessage;
        }
        public void StoreNo(ChildBinaryTreeNode btnNode)
        {
            inputNo = btnNode;
        }
        public ChildBinaryTreeNode GetNo()
        {
            return inputNo;
        }
        public void StoreYes(ChildBinaryTreeNode btnNode)
        {
            inputYes = btnNode;
        }
        public ChildBinaryTreeNode GetYes()
        {
            return inputYes;
        }
    }
}
