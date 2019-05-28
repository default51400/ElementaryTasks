using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7NumericSequence
{
    public static class Validator
    {

        public static bool IsValid(string[] args)
        {
            switch (args.Length)
            {
                case 0:
                    throw new IndexOutOfRangeException("Count values must be = 1.");
                //args.Lenght only = 2, because range take onnly  argumnts
                case 1:
                    if (int.TryParse(args[0], out int finalNumber))
                    {
                        if (finalNumber >= 0) 
                        {
                            if (finalNumber > 2147483647)
                            {
                                throw new ArgumentException("Value must be < 2147483647");
                            }
                            return true;
                        }
                        else
                        {
                            throw new ArgumentException("Values must be > 0");
                        }

                    }
                    else
                    {
                        throw new ArgumentException("Values is not integer. (Min value = -2147483648, max value = 2147483647)");
                    }

                default:
                    throw new ArgumentException("There should be 1 variables");
            }

        }
    }
}
