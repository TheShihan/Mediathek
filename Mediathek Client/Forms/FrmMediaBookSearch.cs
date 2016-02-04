using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLogic.Common;

namespace MediathekClient.Forms
{
    /// <summary>
    /// Media book search
    /// </summary>
    public partial class FrmMediaBookSearch : MediathekClient.Forms.FrmMediaBookBase
    {

        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        public FrmMediaBookSearch()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="session">The current session</param>
        /// <param name="mediaTypeId">The media type that is being handled</param>
        public FrmMediaBookSearch(SessionInfo session, int mediaTypeId)
            : base(session, mediaTypeId)
        {
            InitializeComponent();
        }

        #endregion

        #region Event handlers

        /// <summary>
        /// On form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMediaSearch_Load(object sender, EventArgs e)
        {
            this.IsAddToBasketClmVisible = true;
        }

        /// <summary>
        /// On "OK" button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        } 

        #endregion

    }
}
