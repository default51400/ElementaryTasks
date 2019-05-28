using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7NumericSequence
{
    class NumericSequence: Sequence
    {
        public NumericSequence(int leftNumber, int rightNumber) : base(leftNumber, rightNumber)
        {
            leftNumber = 0;
        }
        public override IEnumerable<int> GetSequenceCollection()
        {
                for (int i = LeftNumber; i * i < RightNumber; i++)
                {
                    yield return i;
                }
        }
        public override StringBuilder GetStringSequence(IEnumerable<int> sequenceCollection)
        {
            StringBuilder result = new StringBuilder();
            bool firstNumber = true;

            foreach (var number in sequenceCollection)
            {
                if (firstNumber)
                {
                    result.Append(number);
                    firstNumber = false;
                }
                else
                {
                    result.Append(", ");
                    result.Append(number);
                }
            }

            return result;
        }
    }
}
