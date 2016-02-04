using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic.Common
{
    /// <summary>
    /// Represents an object where and int value and a string value can be stored.
    /// Mostly useful to fill up comboboxes.
    /// </summary>
    public class GenericIntStringItem : IComparable
    {
        #region Fields

        /// <summary>
        /// The value of the integer
        /// </summary>
        private int intVal;
        /// <summary>
        /// The value of the string
        /// </summary>
        private string stringVal = null; 

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor for object initialization
        /// </summary>
        /// <param name="intVal">The value of the integer</param>
        /// <param name="stringVal">The string value</param>
        public GenericIntStringItem(int intVal, string stringVal)
        {
            this.intVal = intVal;
            this.stringVal = stringVal;
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

        /// <summary>
        /// Get or set the value of the string
        /// </summary>
        public string StringVal
        {
            get { return this.stringVal; }
            set { this.stringVal = value; }
        }

        #endregion

        #region Overwritten methods

        /// <summary>
        /// Out put the string value of the object
        /// </summary>
        /// <returns>String (containing string value of current object)</returns>
        public override string ToString()
        {
            return this.stringVal;
        }

        #endregion

        #region IComparable Members

        /// <summary>
        /// Compare with other object.
        /// Used to sort this object.
        /// </summary>
        /// <param name="obj">The object for comparion</param>
        /// <returns>Comparsion value</returns>
        public int CompareTo(object obj)
        {
            if (this.stringVal == null)
            {
                return -1;
            }

            if (obj is string)
            {
                return this.stringVal.CompareTo((string)obj);
            }

            return 0;
        }

        #endregion
    }
}
