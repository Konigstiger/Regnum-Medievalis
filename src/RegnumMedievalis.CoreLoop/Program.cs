using System;

namespace RegnumMedievalis.CoreLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Regnum Medievalis – Core Simulation");
            Console.WriteLine("Choose mode: [1] Interactive  [2] Automated");
            var input = Console.ReadLine();

            var loop = new MedievalCoreLoop();
            if (input == "2")
            {
                for (int i = 0; i < 10; i++)
                {
                    loop.RunTurn();
                    Console.WriteLine($"Turn {i+1:00}  Treasury={loop.Treasury:0.##}  Stability={loop.Stability:0.##}");
                }
                return;
            }

            while (true)
            {
                Console.WriteLine("Press ENTER to run a turn (or type 'q' to quit).");
                var line = Console.ReadLine();
                if (line?.Trim().ToLowerInvariant() == "q") break;
                loop.RunTurn();
                Console.WriteLine($"Treasury={loop.Treasury:0.##}  Stability={loop.Stability:0.##}");
            }
        }
    }
}
