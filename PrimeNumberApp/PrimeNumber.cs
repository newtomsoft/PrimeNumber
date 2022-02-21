namespace PrimeNumberApp;

public static class PrimeNumber
{
    public static bool IsPrime(ulong number)
    {
        var computeLimit = (ulong)Math.Sqrt(number);
        for (ulong numberTested = 2; numberTested <= computeLimit; numberTested++)
            if (number % numberTested == 0) return false;

        return true;
    }

    public static IEnumerable<ulong> FromTo(ulong from, ulong to)
    {
        if (from < 2) from = 2;
        for (var numberTested = from; numberTested <= to; numberTested++)
            if (IsPrime(numberTested)) yield return numberTested;
    }
}