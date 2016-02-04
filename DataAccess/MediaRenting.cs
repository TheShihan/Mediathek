using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects.DataClasses;

namespace DataAccess
{
    /// <summary>
    /// "Extends" the MediaRenting class
    /// </summary>
    public partial class MediaRenting : EntityObject
    {

        #region Properties

        /// <summary>
        /// Return the duration of the rent in days (integer).
        /// </summary>
        public int Duration
        {
            get
            {
                DateTime endDate;

                if (this.CheckInDate != null)
                {
                    endDate = (DateTime)this.CheckInDate;
                }
                else
                {
                    endDate = DateTime.Now;
                }

                TimeSpan duration = endDate - this.CheckOutDate;

                return duration.Days;
            }
        }

        #endregion

    }
}
