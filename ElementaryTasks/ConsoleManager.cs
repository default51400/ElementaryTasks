using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryTasks
{
    public class ConsoleManager
    {
        #region Fields
        private const string LINE_SEPARATOR = "---------------------------------------------------------------------------";
        private string[] _args;
        private BoardArgumentsValidationResult result;
        #endregion

        #region Props
        public ISurface<ICell> Board { get; set; }
        #endregion

        #region Ctor
        public ConsoleManager(string[] args)
        {
            //TODO: ASK: IT IS TRUE? Так безопасно? если массив строк то у нас поидее и так норм.
            _args = (string[])args.Clone(); 
            CheckArguments();
        }
        #endregion

        private void CheckArguments()
        {
            try
            {
                result = Validator.IsValid(_args);
                if (result.IsValid)
                    PrintResult();
                else
                    throw new ArgumentException("Arguments are not valid.", result.Exception);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("\nAttention:\n" + ex.Message + "\t" + ex?.InnerException.Message);
                ShowInstruction();
                ReInput();
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nAttention:\n" + ex.Message);
                ShowInstruction();
                ReInput();
            }
        }
        public void PrintResult()
        {
            Console.Clear();
            Board = new ChessBoard(result.Height, result.Width);
        }

        //TODO: Set Console size
        //TODO: Check ConsoleSize, if SIZE>ConsSize =reinput

        private void ShowInstruction()
        {
            Console.WriteLine(LINE_SEPARATOR);
            Console.WriteLine("Please read instruction for setting height and width of chess board:");
            Console.WriteLine("Input supports only two unsigned integer number separated by witespace (\"_\"). (Example: 8 8)");
            Console.WriteLine(LINE_SEPARATOR);
        }

        private void ReInput()
        {
            //TODO: ONE VALIDATE
            Console.Write("\nPlease input correct: ");
            string inputValue = Console.ReadLine();
            _args = inputValue.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            CheckArguments();
        }
    }
}
