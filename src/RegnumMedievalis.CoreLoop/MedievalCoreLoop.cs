using System;

namespace RegnumMedievalis.CoreLoop
{
    public class MedievalCoreLoop
    {
        private readonly Random _rng;
        private int _year = 1100;

        public double Treasury { get; private set; } = 1000.0;
        public double Stability { get; private set; } = 100.0;

        public MedievalCoreLoop(int? seed = null)
        {
            _rng = seed.HasValue ? new Random(seed.Value) : new Random();
        }

        public void RunTurn()
        {
            // Simple economic delta
            var income = 100 + _rng.Next(-20, 21);   // 80..120
            var expenses = 90 + _rng.Next(-25, 26);  // 65..115

            Treasury += (income - expenses);

            // Stability shifts slightly, never below 0
            Stability += _rng.Next(-5, 6);           // -5..+5
            if (Stability < 0) Stability = 0;

            _year += 1;
        }
    }
}
