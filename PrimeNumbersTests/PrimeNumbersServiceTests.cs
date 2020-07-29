using PrimeNumbers.Services;
using System;
using Xunit;

namespace PrimeNumbersTests
{
    public class PrimeNumbersServiceTests
    {
        [Theory]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(4, false)]
        [InlineData(5, true)]
        [InlineData(6, false)]
        [InlineData(11, true)]
        [InlineData(53, true)]        
        public void IsPrimeNumberWorksCorrectly(int number, bool expectedResult)
        {
            var sut = new PrimeNumbersService();
            var result = sut.IsPrimeNumber(number);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(3, 3)]
        [InlineData(4, 5)]
        [InlineData(6, 7)]
        [InlineData(10, 11)]
        [InlineData(11, 11)]
        [InlineData(26, 29)]
        [InlineData(180, 181)]
        public void GetNextPrimeNumberWorksCorrectly(int number, int nextPrimeNumber)
        {
            var sut = new PrimeNumbersService();
            var result = sut.GetNextPrimeNumber(number);
            Assert.Equal(nextPrimeNumber, result);
        }
    }    
}
