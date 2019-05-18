﻿using System;

namespace ElementaryTasks
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
                //args.Lenght only = 2, because two-dimensional plane of ChessBoard
                case 2:
                    if (int.TryParse(args[0], out int height) && int.TryParse(args[1], out int width))
                    {
                        if ((height > 0) && (width > 0))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                            throw new ArgumentException("Values must be > 0");
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