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
                    Console.WriteLine("No Play");
                    break;
                case Ladder:
                    toAdd = numOnDie;
                    Console.WriteLine("Ladder, moving forwards.");
                    break;
                case Snake:
                    toAdd = -numOnDie;
                    Console.WriteLine("Snake, moving backwards");
                    break;
            }
            return toAdd;

            static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Snake and Ladder Simulator");
            int initialPosition = 0;
            Console.WriteLine("Starting position = " + initialPosition);
            int numOnDie = RollTheDie();
            Console.WriteLine("Number on the Die rolled = " + numOnDie);
            Console.WriteLine("New position = " + newPosition(numOnDie));
            }
    }
}
