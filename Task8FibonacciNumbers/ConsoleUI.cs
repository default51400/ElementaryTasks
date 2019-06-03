using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SharedDll;

namespace Task8FibonacciNumbers
{
    class ConsoleUI
    {
        private const string LINE_SEPARATOR = "---------------------------------------------------------------------------";

        private string[] _args;

        public ConsoleUI(string[] args)
        {
            this._args = args;
            ShowValues(_args);
        }

        private void ShowValues(string[] args)
        {
            try
            {
                if (Validator.IsValid(args))
                {
                    PrintResult(args); 
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

        private void PrintResult(string[] args)
        {
            Sequence sequence = new FibonacciSequence(int.Parse(args[0]), int.Parse(args[1]));
            IEnumerable<int> sequenceCollection = sequence.GetSequenceCollection();

            Console.WriteLine(sequence.GetStringSequence(sequenceCollection).ToString());
            //StringBuilder stringValues = new StringBuilder();
            //foreach (var item in FibonacciSequence.GetSequenceRange(args))
            //{
            //    stringValues.AppendFormat($"{item}, ");
            //}
            //Console.WriteLine(stringValues.Remove(stringValues.Length - 2, 1));
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
            ShowValues(Console.ReadLine().Split());
            //TODO: неработает 2х неправильно
        }
    }
}
