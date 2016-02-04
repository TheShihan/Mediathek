using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic.Exceptions
{

    /// <summary>
    /// Missing data exception.
    /// Thrown when expected data is missing.
    /// </summary>
    public class ConditionException : ApplicationException
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ConditionException() { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="message">Exception message</param>
        public ConditionException(string message) : base(message) { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="inner">The inner exception</param>
        public ConditionException(string message, Exception inner)
            : base(message, inner) { }
    }
}
