using System.Collections.Generic;
using System.Text;

using SharedDll;

namespace Task8FibonacciNumbers
{
    public class FibonacciSequence : Sequence
    {
        public FibonacciSequence(int leftNumber, int rightNumber) : base(leftNumber, rightNumber) { }

        public override IEnumerable<int> GetSequenceCollection()
        {
            int current = 0;
            int next = 1;
            while (true)
            {
                if (current >= LeftNumber && current <= RightNumber)
                    yield return current;
                int temp = next;
                next = current + next;
                current = temp;

                if (current > RightNumber)
                    yield break;
            }
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
