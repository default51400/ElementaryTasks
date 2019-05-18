using System;

namespace ElementaryTasks
{
    public class ConsoleUI
    {
        private const string LINE_SEPARATOR = "---------------------------------------------------------------------------";

        private ChessBoard _board;
        private string[] _args;
        
        public ConsoleUI(string[] args)
        {
            this._args = args;
            CheckArguments();
            ShowChessBoard();
        }

        private void CheckArguments()
        {
            try
            {
                if (Validator.IsValid(_args))
                {
                    _board = new ChessBoard(_args);
                }
                else
                {
                    throw new ArgumentException("Invalid arguments");
                }
            }
            
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Message:\n" + ex.Message);
                ShowInstruction();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Message:\n" + ex.Message);
                ShowInstruction();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message:\n" + ex.Message);
                ShowInstruction();
            }
        }
        //TODO: Set Console size
        //TODO: Check ConsoleSize, if SIZE>ConsSize =reinput

        private void ShowInstruction()
        {
            Console.WriteLine(LINE_SEPARATOR);
            Console.WriteLine("Your input isn't valid. \nPlease read instruction for setting height and width of chess board:");
            Console.WriteLine("Input supports only two unsigned integer number separated by witespace (\"_\").");
            Console.WriteLine(LINE_SEPARATOR);
            ReInput();
        }

        private void ReInput()
        {
            Console.Write("Please input correct: ");
            string inputValue = Console.ReadLine();
            _args =  inputValue.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            CheckArguments();
        }

        private void ShowChessBoard()
        {
            for (int i = 1; i <= _board.Height; i++)
            {
                for (int j = 1; j <= _board.Width; j++)
                {
                    if (i % 2 == 1)
                        if (j % 2 == 1)
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write(" ");
                        }
                    else
                    if (j % 2 == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write(" ");
                    }
                }
                Console.ResetColor();
                Console.WriteLine();
            }
        }

    }
}
