using PrimeNumbers.Interfaces;
using System;

namespace PrimeNumbers.Services
{
    public class PrimeNumbersService : IPrimeNumbersService
    {
        public bool IsPrimeNumber(int number)
        {
            if (number == 1) return false;
            if (number == 2 || number == 3 || number == 5) return true;
            if (number % 2 == 0 || number % 3 == 0 || number % 5 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            // You can do less work by observing that at this point, all primes 
            // other than 2 and 3 leave a remainder of either 1 or 5 when divided by 6. 
            // The other possible remainders have been taken care of.
            int i = 6; // start from 6, since others below have been handled.
            while (i <= boundary)
            {
                if (number % (i + 1) == 0 || number % (i + 5) == 0)
                    return false;

                i += 6;
            }

            return true;
        }

        public int GetNextPrimeNumber(int number)
        {

            if (number <= 1)
                return 2;
            
            bool found = IsPrimeNumber(number);
            if (found) return number;

            int prime = number;
            while (!found)
            {
                prime++;

                if (IsPrimeNumber(prime))
                    found = true;
            }
            return prime;
        }
    }
}
