using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryTasks
{
    public class ConsoleManager
    {
        private const string LINE_SEPARATOR = "---------------------------------------------------------------------------";

        public ISurface Board { get; set; }
        private string[] _args;

        public ConsoleManager(string[] args)
        {
            _args = (string[])args.Clone(); //TODO: ASK: IT IS TRUE?
            CheckArguments();
        }

        private void CheckArguments()
        {
            try
            {
                BoardArgumentsValidationResult result = Validator.IsValid(_args);
                if (result.IsValid)
                {
                    Console.Clear();
                    Board = new ChessBoard(result.Height, result.Width);
                }
                else
                {
                    throw new ArgumentException("Arguments are not valid", result.Exception);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Message:\n" + ex.Message + "\t" + ex?.InnerException.Message);
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
            _args = inputValue.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            CheckArguments();
        }
    }
}
