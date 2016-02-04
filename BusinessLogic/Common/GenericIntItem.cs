using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic.Common
{
    /// <summary>
    /// Container for an Integer item
    /// </summary>
    public class GenericIntItem
    {

        #region Fields

        /// <summary>
        /// The value of the integer
        /// </summary>
        private int intVal;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor for object initialization
        /// </summary>
        /// <param name="intVal">The value of the integer</param>
        public GenericIntItem(int intVal)
        {
            this.intVal = intVal;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Get or set the value of the integer
        /// </summary>
        public int IntVal
        {
            get { return this.intVal; }
            set { this.intVal = value; }
        }

        #endregion

        #region Overwritten methods

        /// <summary>
        /// Out put the string value of the object
        /// </summary>
        /// <returns>String (containing string value of current object)</returns>
        public override string ToString()
        {
            return this.intVal.ToString();
        }

        #endregion

    }
}
