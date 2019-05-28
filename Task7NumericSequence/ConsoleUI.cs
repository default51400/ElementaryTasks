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
            this._args = (string[])args.Clone();
            ShowValues(_args);
        }

        private void ShowValues(string[] args)
        {
            try
            {
                if (Validator.IsValid(args))
                    PrintResult(args);
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
            Sequence sequence = new NumericSequence(0, int.Parse(args[0]));  //TODO: ASK About zero;
            IEnumerable<int> sequenceCollection = sequence.GetSequenceCollection();

            Console.WriteLine(sequence.GetStringSequence(sequenceCollection).ToString());
        }

        private void ShowInstruction()
        {
            Console.WriteLine(LINE_SEPARATOR);
            Console.WriteLine("Your input isn't valid. \nPlease read instruction:");
            Console.WriteLine("Input supports only one unsigned integer number.  (Example: 898)");
            Console.WriteLine(LINE_SEPARATOR);
            ReInput();
        }

        private void ReInput()
        {
            Console.Write("Please input correct: ");
            ShowValues(Console.ReadLine().Split());
        }
    }
}
