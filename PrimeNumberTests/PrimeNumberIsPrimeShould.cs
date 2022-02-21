namespace PrimeNumberTests;

public class PrimeNumberIsPrimeShould
{
    [Theory]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(5)]
    [InlineData(7)]
    [InlineData(97)]
    [InlineData(47_657_873)]
    [InlineData(200_021_819)]
    public void ReturnTrue(ulong number) => PrimeNumber.IsPrime(number).ShouldBeTrue();


    [Theory]
    [InlineData(4)]
    [InlineData(8)]
    [InlineData(21)]
    [InlineData(723)]
    [InlineData(47_657_879)]
    public void ReturnFalse(ulong number) => PrimeNumber.IsPrime(number).ShouldBeFalse();
}