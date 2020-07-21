using PrimeNumberApp;
using Xunit;

namespace PrimeNumberTests
{
    public class PrimeNumber_IsPrimeShould
    {
        [Fact]
        public void ReturnTrueWhen2()
        {
            Assert.True(PrimeNumber.IsPrime(2));
        }

        [Fact]
        public void ReturnTrueWhen3()
        {
            Assert.True(PrimeNumber.IsPrime(3));
        }

        [Fact]
        public void ReturnFalseWhen4()
        {
            Assert.False(PrimeNumber.IsPrime(4));
        }

        [Fact]
        public void ReturnTrueWhen5()
        {
            Assert.True(PrimeNumber.IsPrime(5));
        }

        [Fact]
        public void ReturnTrueWhen7()
        {
            Assert.True(PrimeNumber.IsPrime(7));
        }

        [Fact]
        public void ReturnTrueWhen97()
        {
            Assert.True(PrimeNumber.IsPrime(97));
        }

        [Fact]
        public void ReturnTrueWhen47_657_873()
        {
            Assert.True(PrimeNumber.IsPrime(47_657_873));
        }

        [Fact]
        public void ReturnFalseWhen47_657_879()
        {
            Assert.False(PrimeNumber.IsPrime(47_657_879));
        }

        [Fact]
        public void ReturnTrueWhen200_021_819()
        {
            Assert.True(PrimeNumber.IsPrime(200_021_819));
        }
        
    }
}
