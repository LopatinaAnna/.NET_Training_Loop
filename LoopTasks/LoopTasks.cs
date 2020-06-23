using System;

namespace LoopTasks
{
    public static class LoopTasks
    {
        /// <summary>
        /// Task 1
        /// </summary>
        public static int SumOfOddDigits(int n)
        {
            int sum = 0;

            while (n != 0)
            {
                if ((n % 10) % 2 != 0)
                    sum += n % 10;
                n /= 10;
            }

            return sum;
        }

        /// <summary>
        /// Task 2
        /// </summary>
        public static int NumberOfUnitsInBinaryRecord(int n)
        {
            int counter = 0;
            string binary = Convert.ToString(n, 2);

            Console.WriteLine(counter);
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                {
                    counter++;
                }
            }

            return counter;
        }

        /// <summary>
        /// Task 3
        /// </summary>
        public static int SumOfFirstNFibonacciNumbers(int n)
        {
            if (n <= 2)
            {
                return n - 1;
            }

            int n1 = 0;
            int n2 = 1;
            int n3;
            int sum = 1;

            for (int i = 2; i < n; ++i)
            {
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
                sum += n3;
            }

            return sum;
        }
    }
}