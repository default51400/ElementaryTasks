using System;

namespace ElementaryTasks
{
    public static class Validator
    {
        private const int MAX_VALUE = 30;//TODO: TO UserConfig

        public static BoardArgumentsValidationResult IsValid(string[] args)
        {
            BoardArgumentsValidationResult result = new BoardArgumentsValidationResult();
            switch (args.Length)
            {
                //args.Lenght only = 2, because two-dimensional plane of ChessBoard
                case 2://TODO: Change number 2, ask about -1,0,1
                    if (int.TryParse(args[0], out int height) && int.TryParse(args[1], out int width))
                    {
                        if ((height > 0) && (width > 0) && (height < MAX_VALUE) && (width < MAX_VALUE))
                        {
                            result.IsValid = true;
                            result.Height = height;
                            result.Width = width;
                        }
                        //TODO: ASK about MAX VALUE
                        //TODO: result.Description || уйти от ексепшн
                        else result.Exception = new ArgumentException($"Values must be > 0 and less {MAX_VALUE}.");
                    }
                    else result.Exception = new ArgumentException($"Values is not integer.");
                    break;

                default:
                    result.Exception = new ArgumentException($"Count of input values = {args.Length}. Count values must be = 2.");
                    break;
            }

            return result;
        }
    }
}