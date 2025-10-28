using System;

namespace RegnumMedievalis.CoreLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Regnum Medievalis – Core Simulation");
            var game = new MedievalCoreLoop();

            Console.WriteLine("\nChoose mode: [1] Interactive [2] Automated Simulation");
            var choice = Console.ReadLine();

            if (choice == "2")
            {
                Console.WriteLine("Running 10 automated turns...\n");
                for (int i = 0; i < 10; i++) game.RunTurn();
                Console.WriteLine("\nSimulation complete.");
            }
            else
            {
                while (true)
                {
                    game.RunTurn();
                    Console.WriteLine("Press [Enter] for next year or type 'exit' to quit.");
                    if (Console.ReadLine()?.ToLower() == "exit") break;
                }
            }
        }
    }
}
