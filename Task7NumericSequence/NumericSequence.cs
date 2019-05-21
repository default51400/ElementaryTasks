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
            StringBuilder result = null;
            for (int i = 0; i*i < number; i++)
            {
                result.AppendFormat("{0}, ", i);
            }
            return result.Remove(result.Length - 2, 1).ToString();
        }
    }
}
