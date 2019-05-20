using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8FibonacciNumbers
{
    public static class Fibonacci
    {
        public static int CalculateFibonacci(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("The value must be > 0.");
            }

            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }

            return CalculateFibonacci(n - 1) + CalculateFibonacci(n - 2);
        }

        public static string GetSequenceInRange(int startRange, int endRange)
        {
            if (startRange < 1 || endRange < 1)
            {
                throw new ArgumentException("Range value should not be less then 1.");
            }

            string currentString = string.Empty;
            for (int number = 0; number < endRange; number++)
            {
                if (CalculateFibonacci(number) >= startRange)
                {
                    if (CalculateFibonacci(number) >= endRange)
                    {
                        break;
                    }

                    currentString += string.Format(CalculateFibonacci(number) + ", ");
                }
            }

            return currentString.Remove(currentString.Length-2, 1);
        }

        public static IEnumerable GetSequenceRange(string[] args)
        {
            int startRange = Convert.ToInt32(args[0]);
            int endRange = Convert.ToInt32(args[1]);

            if (startRange < 0 || endRange < 0)
            {
                throw new ArgumentException("Range value should not be less then 0.");
            }

            //List<int> values = new List<int>();
            for (int number = 0; number < endRange; number++)
            {
                if (CalculateFibonacci(number) >= startRange)
                {
                    if (CalculateFibonacci(number) >= endRange)
                    {
                        break;
                    }

                    yield return CalculateFibonacci(number);
                    //values.Add(CalculateFibonacci(number));
                }
            }
        }
        
    }
}       
