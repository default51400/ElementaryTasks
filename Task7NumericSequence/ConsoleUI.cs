using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7NumericSequence
{
    class ConsoleUI
    {
        private const string LINE_SEPARATOR = "---------------------------------------------------------------------------";

        private string[] _args;

        public ConsoleUI(string[] args)
        {
            this._args = args;
            ShowValues();
        }

        private void ShowValues()
        {
            try
            {
                if (Validator.IsValid(_args))
                {
                    Console.WriteLine(NumericSequence.Calculate(int.Parse(_args[0])) ); 
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
        private void ShowInstruction()
        {
            Console.WriteLine(LINE_SEPARATOR);
            Console.WriteLine("Your input isn't valid. \nPlease read instruction:");
            Console.WriteLine("Input supports only one unsigned integer number.");
            Console.WriteLine(LINE_SEPARATOR);
            ReInput();
        }

        private void ReInput()
        {
            Console.Write("Please input correct: ");
            _args[0] = Console.ReadLine();
            ShowValues();
        }
    }
}
