using System;

namespace ElementaryTasks
{
    public static class Validator
    {

        public static bool IsValid(string[] args)
        {
            switch (args.Length)
            {
                //args.Lenght only = 2, because two-dimensional plane of ChessBoard
                case 2:
                    if (int.TryParse(args[0], out int height) && int.TryParse(args[1], out int width))
                    {
                        return true;
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