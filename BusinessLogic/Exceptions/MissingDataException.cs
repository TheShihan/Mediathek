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
    public class MissingDataException : ApplicationException
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public MissingDataException() { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="message">Exception message</param>
        public MissingDataException(string message) : base(message) { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="inner">The inner exception</param>
        public MissingDataException(string message, Exception inner)
            : base(message, inner) { }
    }
}
