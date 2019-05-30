using System;

namespace ElementaryTasks
{
    public static class Validator
    {
        private const int MAX_VALUE = 30;//TODO: TO UserConfig
        private const int DEFAULT_BOARD_PARAMS_COUNT = 2;

        public static bool IsValid(string[] args, out int height, out int width)
        {
            switch (args.Length)
            {
                case DEFAULT_BOARD_PARAMS_COUNT:
                    if (int.TryParse(args[0], out int parsedHeight) && int.TryParse(args[1], out int parsedWidth))
                    {
                        if ((parsedHeight > 0) && (parsedWidth > 0) && (parsedHeight < MAX_VALUE) && (parsedWidth < MAX_VALUE))
                        {
                            height = parsedHeight;
                            width = parsedWidth;
                            return true;
                        }
                        else throw new ArgumentException($"Values must be > 0 and less {MAX_VALUE}.");
                    }
                    else throw new ArgumentException($"Values is not integer.");

                default:
                    throw new ArgumentException($"Count of input values = {args.Length}. Count values must be = 2.");
            }
        }
    }
}