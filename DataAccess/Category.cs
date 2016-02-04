using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects.DataClasses;

namespace DataAccess
{
    public partial class Category : EntityObject, IComparable
    {

        #region IComparable Members

        /// <summary>
        /// Compare to an other instance
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj is Category &&
                ((Category)obj) != null &&
                ((Category)obj).Name != null)
            {
                //return ((Category)obj).Name.CompareTo(this.Name);
                return this.Name.CompareTo(((Category)obj).Name);
            }

            return 0;
        }

        #endregion
    }
}
