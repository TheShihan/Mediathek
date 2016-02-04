using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects.DataClasses;

namespace DataAccess
{
    /// <summary>
    /// "Extends" the Reservation class
    /// </summary>
    public partial class Reservation : EntityObject
    {

        #region Properties

        /// <summary>
        /// Return the duration of the reservation in days (integer).
        /// </summary>
        public int Duration
        {
            get
            {
                DateTime endDate;

                if (this.EndDate != null)
                {
                    endDate = (DateTime)this.EndDate;
                }
                else
                {
                    endDate = DateTime.Now;
                }

                TimeSpan duration = endDate - this.CreationDate;

                return duration.Days;
            }
        }

        #endregion

    }
}
