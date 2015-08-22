using System;
using System.Collections.Generic;
using System.Text;

namespace NStorage.Utility
{
    internal class AssertFailedException : ApplicationException
    {
        public AssertFailedException(string message)
            : base(message)
        {

        }
    }
}
