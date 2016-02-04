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
    /// Media music search
    /// </summary>
    public partial class FrmMediaMusicSearch : MediathekClient.Forms.FrmMediaMusicBase
    {
        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        public FrmMediaMusicSearch()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="session">The current session</param>
        /// <param name="mediaTypeId">The media type that is being handled</param>
        public FrmMediaMusicSearch(SessionInfo session, int mediaTypeId)
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
