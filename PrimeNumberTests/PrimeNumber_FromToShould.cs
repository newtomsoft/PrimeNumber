using PrimeNumberApp;
using System.Collections.Generic;
using Xunit;

namespace PrimeNumberTests
{
    public class PrimeNumber_FromToShould
    {
        [Fact]
        public void Return2whenFrom1To2()
        {
            Assert.Equal(new List<ulong>() { 2 }, PrimeNumber.FromTo(1,2));
        }

        [Fact]
        public void Return2_3whenFrom1To3()
        {
            Assert.Equal(new List<ulong>() { 2, 3 }, PrimeNumber.FromTo(1,3));
        }

        [Fact]
        public void Return2_3whenFrom1To4()
        {
            Assert.Equal(new List<ulong>() { 2, 3 }, PrimeNumber.FromTo(1, 4));
        }

        [Fact]
        public void Return2_3_5whenFrom1To5()
        {
            Assert.Equal(new List<ulong>() { 2, 3, 5 }, PrimeNumber.FromTo(1, 5));
        }

        [Fact]
        public void ReturnGoodListwhenFrom1To100()
        {
            Assert.Equal(new List<ulong>() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 }, PrimeNumber.FromTo(1, 100));
        }
    }
}
