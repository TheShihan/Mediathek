using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;
using BusinessLogic.Common;
using MediathekClient.Common;

namespace MediathekClient.Forms
{
    /// <summary>
    /// Used for media type selection in the media managing process.
    /// </summary>
    public partial class FrmMediaTypeSelector : FrmDlgBase
    {

        #region Fields

        /// <summary>
        /// The current session
        /// </summary>
        private SessionInfo session = null;

        /// <summary>
        /// Bussines logic handler class
        /// </summary>
        private BusinessLogicHandler bl = new BusinessLogicHandler();

        /// <summary>
        /// The form mode: specify if the media dialogues shall be opened 
        /// for managing media or for media selection.
        /// </summary>
        private FormMode formMode = FormMode.Selector;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        public FrmMediaTypeSelector()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="session">The current session</param>
        /// <param name="formMode">
        /// The form mode: specify if the media dialogues shall be opened 
        /// for managing media or for media selection.
        /// </param>
        public FrmMediaTypeSelector(SessionInfo session, FormMode formMode)
            : this()
        {
            this.session = session;
            this.formMode = formMode;
        }

        #endregion

        /// <summary>
        /// On form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMediaManager_Load(object sender, EventArgs e)
        {
            if (this.cbMediaType != null)
            {
                this.cbMediaType.DataSource = bl.GetMediaTypes();
            }
        }

        /// <summary>
        /// Button "OK" clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butOk_Click(object sender, EventArgs e)
        {
            if (this.cbMediaType != null && this.cbMediaType.SelectedItem != null)
            {
                int mediaTypeId = (int)this.cbMediaType.SelectedValue;

                FrmMediaOverviewBase frmMediaBase = null;

                switch (mediaTypeId)
                {
                    case 1:
                        // books
                        if (this.formMode == FormMode.Manager)
                        {
                            frmMediaBase = new FrmMediaBookManager(this.session, mediaTypeId);
                        }
                        else if (this.formMode == FormMode.Selector)
                        {
                            frmMediaBase = new FrmMediaBookSearch(this.session, mediaTypeId);
                        }
                        break;
                    case 2:
                        // music
                        if (this.formMode == FormMode.Manager)
                        {
                            frmMediaBase = new FrmMediaMusicManager(this.session, mediaTypeId);
                        }
                        else if (this.formMode == FormMode.Selector)
                        {
                            frmMediaBase = new FrmMediaMusicSearch(this.session, mediaTypeId);
                        }
                        break;
                    case 3:
                        // videos
                        if (this.formMode == FormMode.Manager)
                        {
                            frmMediaBase = new FrmMediaVideoManager(this.session, mediaTypeId);
                        }
                        else if (this.formMode == FormMode.Selector)
                        {
                            frmMediaBase = new FrmMediaVideoSearch(this.session, mediaTypeId);
                        }
                        break;
                    case 4:
                        // misc
                        if (this.formMode == FormMode.Manager)
                        {
                            frmMediaBase = new FrmMediaMiscManager(this.session, mediaTypeId);
                        }
                        else if (this.formMode == FormMode.Selector)
                        {
                            frmMediaBase = new FrmMediaMiscSearch(this.session, mediaTypeId);
                        }
                        break;
                }

                if (frmMediaBase != null)
                {
                    this.Visible = false;
                    frmMediaBase.ShowDialog(this.Owner);
                    this.Close();
                }
                else
                {
                    // show error
                    Tools.ShowMessageBox(MessageBoxType.Error,
                        Localization.MsgCommonSelectionNotHandled,
                        this);
                }
            }
        }

    }
}
