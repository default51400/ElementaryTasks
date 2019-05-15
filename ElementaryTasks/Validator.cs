using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementaryTasks
{
    public static class ValidatorTwoIntegerNumbers //: IValidator
    {
        //private string[] _args;
        //public ValidatorTwoIntegerNumbers(string[] args)
        //{
        //    this._args = args;
        //}
        public static void Validate(string[] args)
        {
            //TODO: Проверка что мы вводим 2 целочисленных значения
            if (int.TryParse(args[0], out int width) && int.TryParse(args[1], out int height))
            {
                //Width = width;
                //Height = height;
            }
            else
            {
                throw new ArgumentException("Invalid input args");
                //TODO: Добавить вызов инструкции
            }
        }

        //private bool IsValid()
        //{
        //    return true;
        //}

    }
}