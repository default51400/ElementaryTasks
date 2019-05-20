using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryTasks
{
    public class BoardArgumentsValidationResult
    { 
        public bool IsValid { get; set; }
        public Exception Exception { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
    }
}
