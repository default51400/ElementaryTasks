using System;

namespace ElementaryTasks
{
    public static class Validator //: IValidator
    {

        public static bool IsValid(string[] args, out int outHeight, out int outWidth)
        {
            //TODO: Проверка что мы вводим 2 целочисленных значения
            if (int.TryParse(args[0], out int width) && int.TryParse(args[1], out int height))
            {
                outHeight = height;
                outWidth = width;
                return true;
            }
            else
            {
                outHeight = 0;
                outWidth = 0;
                return false;
            }


        }

    }
}