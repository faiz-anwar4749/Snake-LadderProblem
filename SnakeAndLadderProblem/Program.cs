using System;

namespace SnakeAndLadderProblem
{
    class Program
    {
        public const int NoPlay = 0;
        public const int Ladder = 1;
        public const int Snake = 2;
        public static int RollTheDie()
        {
            Random random = new Random();
            int numOnDie = random.Next(1, 7);
            return numOnDie;
        }
        public static int newPosition(int numOnDie)
        {
            int toAdd = 0;
            Random random = new Random();
            int toMove = random.Next(0, 3);
            switch (toMove)
            {
                case NoPlay:
                    break;
                case Ladder:
                    toAdd = numOnDie;
                    break;
                case Snake:
                    toAdd = -numOnDie;
                    break;
            }
            return toAdd;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Snake and Ladder Simulator");
            int initialPosition = 0, nextPosition;
            int count = 0;
            while (initialPosition < 100)
            {
                int numOnDie = RollTheDie();
                count++;
                int toAdd = newPosition(numOnDie);
                nextPosition = initialPosition + toAdd;
                //checking if player has moved below position 0
                if (nextPosition < 0)
                    initialPosition = 0;
                else
                    initialPosition = nextPosition;
            }
            Console.WriteLine("Number on the Die rolled = " + count);
            Console.WriteLine("Current position = " + initialPosition);
        }
    }
}
