using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace BusinessLogic.Common
{
    /// <summary>
    /// Various validation logic
    /// </summary>
    public class Validation
    {

        /// <summary>
        /// Check whether the specified email address is in a valid email format (RFC 822).
        /// </summary>
        /// <param name="emailAddress">Email address to validate.</param>
        /// <returns><c>True</c> if the email address is formatted correctly, otherwise <c>False</c>.</returns>
        public static bool IsValidEmail(string emailAddress)
        {
            return Regex.IsMatch(emailAddress, @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
        }

    }
}
