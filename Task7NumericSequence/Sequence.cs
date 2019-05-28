using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7NumericSequence
{
    public abstract class Sequence
    {
        public int LeftNumber { get; private set; }
        public int RightNumber { get; private set; }

        public Sequence(int leftNumber, int rightNumber)
        {
            this.LeftNumber = leftNumber;
            this.RightNumber = rightNumber;
        }

        public abstract IEnumerable<int> GetSequenceCollection();
        public abstract StringBuilder GetStringSequence(IEnumerable<int> sequenceCollection);
       
    }
}
