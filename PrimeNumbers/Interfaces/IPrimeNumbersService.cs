namespace PrimeNumbers.Interfaces
{
    public interface IPrimeNumbersService
    {
        int GetNextPrimeNumber(int number);
        bool IsPrimeNumber(int number);
    }
}