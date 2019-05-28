using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Task7NumericSequence;

namespace Task8FibonacciNumbers
{
    public class FibonacciSequence: Sequence
    {
        public FibonacciSequence(int leftNumber, int rightNumber): base(leftNumber, rightNumber)
        {
        }

        public override IEnumerable<int> GetSequenceCollection()
        {
            int previous = 0;
            int current = 1;
            
            while (previous + current <= RightNumber)
            {
                yield return previous;

                int next = previous + current;
                previous = current;
                current = next;

                if (current > LeftNumber)
                    yield return current;
            }
            //if (n < 0)
            //    throw new ArgumentException("The value must be > 0.");
            //if (n == 0)
            //    yield return 0;
            //if (n == 1)
            //    yield return 1;

            //for (int i = 0; i < n; i++)
            //{
            //    yield return (i - 1) + (i - 2);
            //}
        }
        public override StringBuilder GetStringSequence(IEnumerable<int> sequenceCollection)
        {
            StringBuilder result = new StringBuilder();
            bool firstNumber = true;

            foreach (var number in sequenceCollection)
            {
                if (number >= LeftNumber && number <= RightNumber)
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
                
            }

            return result;
        }
        

        //public IEnumerable<int> GetRangeSequence(int startRange, int endRange)
        //{
        //    if (startRange < 1 || endRange < 1)
        //    {
        //        throw new ArgumentException("Range value should not be less then 1.");
        //    }
        //    IEnumerable<int> rangeValues = 
        //    for (int number = 0; number < endRange; number++)
        //    {
        //        if (GetSequenceCollection(number) >= startRange)
        //        {
        //            if (GetSequenceCollection(number) >= endRange)
        //            {
        //                break;
        //            }

        //            yield return GetSequenceCollection(number);
        //        }
        //    }

        //    return rangeValues;
        //    //StringBuilder currentString = new StringBuilder();
        //    //for (int number = 0; number < endRange; number++)
        //    //{
        //    //    if (GetSequenceCollection(number) >= startRange)
        //    //    {
        //    //        if (GetSequenceCollection(number) >= endRange)
        //    //        {
        //    //            break;
        //    //        }

        //    //        currentString.AppendFormat($"{GetSequenceCollection(number)}, ");                }
        //    //}

        //    //return currentString.Remove(currentString.Length-2, 1).ToString();
        //}
    }
}       
