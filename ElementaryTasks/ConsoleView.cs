using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryTasks
{
    public class ConsoleView: IView
    {
        private const string LINE_SEPARATOR = "---------------------------------------------------------------------------";
        
        private IDraw _userInterface;

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

        public void ShowSurface(ISurface surface)
        {
            _userInterface = new ConsoleUI();
            _userInterface.Draw(surface);
        }

        //TODO: Ask about dependency injection
        public string[] ReInput()
        {
            string inputValue = Console.ReadLine();
            string[] arguments = inputValue.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            return arguments;
        }
        #endregion
    }
}
