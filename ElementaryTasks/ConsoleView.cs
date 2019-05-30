using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryTasks
{
    public class ConsoleView: IView
    {
        #region Fields
        private const string LINE_SEPARATOR = "---------------------------------------------------------------------------";
        #endregion

        #region Ctor
        public ConsoleView()
        {
        }
        #endregion

        #region Methods
        public void ShowErrorMessage(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(text);
            Console.WriteLine();
            Console.ResetColor();
        }

        public void ShowInstruction(string text)
        {
            Console.WriteLine(LINE_SEPARATOR);
            Console.WriteLine(text);
            Console.WriteLine(LINE_SEPARATOR);
            Console.WriteLine();
        }

        public void ShowResult(IDraw ui)
        {
            //ui.Draw
        }

        private void ReInput()
        {
            //TODO: ONE VALIDATE
            Console.Write("\nPlease input correct: ");
            string inputValue = Console.ReadLine();
            //_args = inputValue.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //CheckArguments();
        }
        #endregion
    }
}
