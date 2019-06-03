using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedDll;

namespace Task7NumericSequence
{
    class NumericSequence: Sequence
    {

        private NumericSequence(int leftNumber, int rightNumber) : base(leftNumber, rightNumber) { }

        public NumericSequence(int rightNumber) : this(0, rightNumber) { }

        public override IEnumerable<int> GetSequenceCollection()
        {
                for (int i = LeftNumber; i * i < RightNumber; i++)
                    yield return i;
        }
       
    }
}
