const ulong from = 18_446_744_073_709_551_550;
const ulong to = 18_446_744_073_709_551_557;

Console.WriteLine($"prime numbers from {from} to {to}");
foreach (var primeNumber in PrimeNumber.FromTo(from, to))
    Console.Write(primeNumber + " ");
