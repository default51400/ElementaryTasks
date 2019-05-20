using System;

namespace ElementaryTasks
{
    public static class Validator
    {

        public static BoardArgumentsValidationResult IsValid(string[] args)
        {
            BoardArgumentsValidationResult result = new BoardArgumentsValidationResult();
            switch (args.Length)
            {
                case 0:
                    result.Exception = new ArgumentOutOfRangeException("Count values must be = 2.");
                    break;

                //args.Lenght only = 2, because two-dimensional plane of ChessBoard
                case 2:
                    if (int.TryParse(args[0], out int height) && int.TryParse(args[1], out int width))
                    {
                        if ((height > 0) && (width > 0))
                        {
                            result.IsValid = true;
                            result.Height = height;
                            result.Width = width;
                        }
                        else
                        {
                            result.Exception = new ArgumentException("Values must be > 0");
                        }
                    }
                    else
                    {
                        result.Exception = new ArgumentException("Values is not integer");
                    }
                    break;

                default:
                    result.Exception = new ArgumentException("There should be 2 variables");
                    break;
            }
            return result;
        }
    }
}