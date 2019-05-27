using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8FibonacciNumbers
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
                    StringBuilder stringValues = new StringBuilder();
                    foreach (var item in Fibonacci.GetSequenceRange(_args))
                    {
                        stringValues.AppendFormat($"{item}, ");
                    }
                    Console.WriteLine(stringValues.Remove(stringValues.Length - 2, 1));
                }
                else
                {
                    Console.WriteLine("Values are not valid.");
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
            Console.WriteLine("Input supports only two unsigned integer number separated by comma (\",\"). (Example: 5, 99)");
            Console.WriteLine(LINE_SEPARATOR);
            ReInput();
        }

        private void ReInput()
        {
            Console.Write("Please input correct: ");
            string inputValue = Console.ReadLine();
            _args = inputValue.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            ShowValues();
        }
    }
}
