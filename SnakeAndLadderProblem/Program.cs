using System;

namespace SnakeAndLadderProblem
{
    class Program
    {
        public static int RollTheDie()
        {
            Random random = new Random();
            int numOnDie = random.Next(1, 7);
            return numOnDie;
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Snake and Ladder Simulator");
            int initialPosition = 0;
            Console.WriteLine("Starting position = " + initialPosition);
            int numOnDie = RollTheDie();
            Console.WriteLine("Number on the Die rolled = " + numOnDie);
        }
    }
}
