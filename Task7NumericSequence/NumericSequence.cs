using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7NumericSequence
{
    static class NumericSequence
    {
        public static string Calculate(int number)
        {
            string result = string.Empty;
            for (int i = 0; i*i < number; i++)
            {
                result += i;
                result += ", ";
            }
            return result.Remove(result.Length - 2, 1);
        }
    }
}
