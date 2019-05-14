using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementaryTasks
{
    public interface IValidator
    {
        void Validate(); // If (!Validate params) return ShowProgramInstruction();
    }
}