using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class MathLib
    {
        // This method must return the "faculty" of n, also written n!,
        // where n! = n x (n-1) x (n-2) x ... x 2 x 1
        // Example: the "faculty" of 4 is 4! = 4 x 3 x 2 x 1 = 24
        // NB: If n < 1, then the faculty is 1
        //
        public int Faculty(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            int sum = n * Faculty(n - 1);

            return sum;
        }

        // This method must return the sum of the numbers between
        // "start" and "end"
        // Example: If start = 3 and end = 7, the interval sum will
        // be 3 + 4 + 5 + 6 + 7 = 25;
        // NB: If start > end, the sum is 0 (zero)
        
        public int IntervalSum(int start, int end)
        {
            int sum = 0;
            
            for (int i = start; i <= end; i++)
            {
                sum = sum + i;
                
            }

            return sum;
        }

        // This method must return the highest square number
        // below the given limit limit
        // Example: If the limit is 20, the highest square below the
        // limit is 16 (the square of 4), since the next square 
        // (the square of 5) is 25.
        // NB: If the limit is zero or negative, return zero
        public int HighestSquareBelowLimit(int limit)
        {
            int resolved = 0;

            for (int i = 0; i*i < limit; i++)
            {
                resolved = i * i; 

            }
            
            //sum = Math.Sqrt(limit);
                
            // This needs to be changed...
            return resolved;
        }


        // [DIFFICULT]
        // This method must return true if the given number is
        // a prime number, otherwise it should return false.
        // Tip: A prime number can only be divded by 1 and itself, so
        // dividing it with any other number will leave a remainder
        // NB: Negative numbers are not prime numbers
        public bool IsPrime(int n)
        {
            if (n == 0 && n == 1)
                return false;
            
            
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
        }
    }
}
