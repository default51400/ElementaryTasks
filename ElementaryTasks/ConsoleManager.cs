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
        #endregion

        #region Props
        #endregion

        #region Ctor
        public ConsoleManager(string[] args)
        {
            _args = (string[])args.Clone(); 
            CheckArguments();
        }
        #endregion

        private void CheckArguments()
        {
            
        }
        public void ShowErrorMessage(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        private void ShowInstruction(string text)
        {
            Console.WriteLine(LINE_SEPARATOR);
            Console.WriteLine(text);
            //Console.WriteLine("Please read instruction for setting height and width of chess board:");
            //Console.WriteLine("Input supports only two unsigned integer number separated by witespace (\"_\"). (Example: 8 8)");
            Console.WriteLine(LINE_SEPARATOR);
            Console.WriteLine();
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
