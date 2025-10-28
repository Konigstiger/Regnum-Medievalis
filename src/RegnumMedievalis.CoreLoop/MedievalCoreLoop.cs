using System;
using System.Collections.Generic;

namespace RegnumMedievalis.CoreLoop
{
    public class MedievalCoreLoop
    {
        private int year = 1100;
        private Random rng = new Random();
        public double Treasury { get; private set; } = 1000;
        public double Stability { get; private set; } = 100;

        public void RunTurn()
        {
            Console.WriteLine($"\nYear {year}: Council convenes...");
            double income = rng.Next(100, 300);
            double expense = rng.Next(80, 250);
            Treasury += income - expense;
            Stability += rng.Next(-5, 6);
            year++;
            Console.WriteLine($"Income: {income}, Expense: {expense}, Treasury: {Treasury:F2}, Stability: {Stability}%");
        }
    }
}
