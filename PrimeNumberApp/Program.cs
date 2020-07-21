using System;

namespace PrimeNumberApp
{
    static class Program
    {
        static void Main()
        {
            var from = 18_446_744_073_709_551_550;
            var to = 18_446_744_073_709_551_615;
            Console.WriteLine($"prime numbers from {from} to {to}");
            foreach (var primeNumber in PrimeNumber.FromTo(from, to))
                Console.Write(primeNumber + " ");
        }
    }
}
