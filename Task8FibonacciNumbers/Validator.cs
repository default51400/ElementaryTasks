﻿using System;


namespace Task8FibonacciNumbers
{
    public static class Validator
    {

        public static bool IsValid(string[] args)
        {
            switch (args.Length)
            {
                case 0:
                    throw new IndexOutOfRangeException("Count values must be = 2.");
                    break;
                //args.Lenght only = 2, because range take onnly  argumnts
                case 2:
                    if (int.TryParse(args[0], out int startPosition) && int.TryParse(args[1], out int endPosition))
                    {
                        if (startPosition < endPosition)
                        {
                            if ((startPosition >= 0) && (endPosition >= 0))
                            {
                                if (endPosition > int.MaxValue)
                                {
                                    throw new ArgumentException("Values must be < 2147483647");
                                }
                                return true;
                            }
                            else
                            {
                                //return false;
                                throw new ArgumentException("Values must be > 0");
                            }
                        }
                        else
                        {
                            throw new ArgumentException("First values must be less than second value.");
                        }
                    }
                    else
                    {
                        return false;
                        throw new ArgumentException("Values is not integer");
                    }
                    break;

                default:
                    return false;
                    throw new ArgumentException("There should be 2 variables");
                    break;
            }

        }
    }
}