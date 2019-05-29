using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ConsoleManager consoleManager = new ConsoleManager(args);
                IDraw consoleUI = new ConsoleUI();
                consoleUI.Draw(consoleManager.Board);
                
                //Valid + create border
                result = Validator.IsValid(_args);
                if (result.IsValid)
                    PrintResult();
            }
            catch (ArgumentException ex)
            {
            //UI.Error(string error)
                Console.WriteLine("\nAttention:\n" + ex.Message + "\t" + ex?.InnerException.Message);
                ShowInstruction();
                ReInput();
            }
            catch (Exception ex)
            {
                 //UI.Error(string error)
                Console.WriteLine("\nAttention:\n" + ex.Message);
                ShowInstruction();
                ReInput();
            }
        }
    }

}
