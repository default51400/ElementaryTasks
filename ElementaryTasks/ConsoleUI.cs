using System;

namespace ElementaryTasks
{
    public class ConsoleUI
    {
        private const string LINE_SEPARATOR = "==================================================================";

        private ChessBoard _board;
        private string[] _args;
        public ConsoleUI()
        {
            _board = new ChessBoard();
        }
        public ConsoleUI(string[] args)
        {
            this._args = args;
        }

        private void CheckArgs() 
        {
            switch (_args.Length)
            {
                //args.Lenght only = 2, because two-dimensional plane
                case 2:
                    if (Validator.IsValid(_args, out int outWidth, out int outHeight))
                    {
                        _board.Width = outWidth;
                        _board.Height = outHeight;

                    }
                    else
                    {
                        ShowInstruction();
                    }
                    break;

                default: ShowInstruction();
                    break;
            }
        }
        public void ShowInstruction()
        {
            Console.WriteLine(LINE_SEPARATOR);
            Console.WriteLine("Please input correct two unsigned integer number, separated by witespace (\"_\") ");
            Console.WriteLine(LINE_SEPARATOR);
        }
        public void Show()
        {
            for (int i = 1; i <= _board.Height; i++)
            {
                for (int j = 1; j <= _board.Width; j++)
                {
                    if (i % 2 == 1)
                        if (j % 2 == 1) Console.Write(" ");
                        else Console.Write("*");
                    else
                    if (j % 2 == 1) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

    }
}
