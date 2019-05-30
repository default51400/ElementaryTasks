using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryTasks
{
    class Program
    {
        private const string INSTRUCTION = "Please read instruction for setting height and width of chess board:\n" +
            "Input supports only two unsigned integer number separated by witespace (\"_\"). (Example: 8 8)";

        static void Main(string[] args)
        {
            IView view = new ConsoleView();
            try
            {
                if (Validator.IsValid(args, out int height, out int width))
                {
                    
                    IDraw ui = new ConsoleUI();
                    ISurface board = new ChessBoard(height, width);
                    ui.Draw(board);
                }
            }
            catch (ArgumentException ex)
            {
                view.ShowErrorMessage(ex.Message);
                view.ShowInstruction(INSTRUCTION);
                //ReInput();
            }
            catch (Exception ex)
            {
                view.ShowErrorMessage(ex.Message);
                view.ShowInstruction(INSTRUCTION);
                //ReInput();
            }
        }
    }

}
