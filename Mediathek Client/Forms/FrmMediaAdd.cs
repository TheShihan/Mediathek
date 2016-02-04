using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;
using BusinessLogic.Common;
using DataAccess;
using MediathekClient.Common;

namespace MediathekClient.Forms
{
    /// <summary>
    /// Media add form
    /// </summary>
    public partial class FrmMediaAdd : FrmDlgBase
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
        /// The media type ID that is being handled
        /// </summary>
        private int mediaTypeId;

        /// <summary>
        /// Container that stores the ID of the new media ID
        /// </summary>
        private GenericIntItem mediaIdContainer = null;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        public FrmMediaAdd()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="session">The current session</param>
        /// <param name="mediaTypeId">The media type that is being handled</param>
        /// <param name="mediaIdContainer">Container for storing the new media ID</param>
        public FrmMediaAdd(SessionInfo session, int mediaTypeId, GenericIntItem mediaIdContainer)
            : this()
        {
            this.session = session;
            this.mediaTypeId = mediaTypeId;
            this.mediaIdContainer = mediaIdContainer;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Fill out the media type textbox
        /// </summary>
        private void FillMediaType()
        {
            List<MediaType> types = bl.GetMediaTypes();

            foreach (MediaType mt in types)
            {
                if (mt.MediaTypeId.Equals(this.mediaTypeId))
                {
                    this.txtMediaType.Text = mt.TypeName;
                    break;
                }
            }
        }

        /// <summary>
        /// Fill out the categories ComboBox
        /// </summary>
        private void FillCategories()
        {
            List<Category> categories =
                bl.GetCategoriesByMediaTypeId(this.mediaTypeId);

            foreach (Category cat in categories)
            {
                this.cbCategory.Items.Add(new GenericIntStringItem(cat.CategoryId, cat.Name));
            }

            // select first item in list
            if (this.cbCategory.Items.Count > 0)
            {
                this.cbCategory.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Validate the form data
        /// </summary>
        /// <returns>True = form data is valid, else false</returns>
        private bool ValidateForm()
        {
            return !string.IsNullOrEmpty(this.txtTitle.Text) &&
                !string.IsNullOrEmpty(this.txtDesc.Text) &&
                !string.IsNullOrEmpty(this.cbCategory.Text) &&
                this.cbCategory.SelectedItem != null;
        }

        /// <summary>
        /// Adds the media to the database
        /// </summary>
        private void AddMedia()
        {
            try
            {
                this.butAdd.Enabled = false;

                if (ValidateForm())
                {
                    // form data is OK
                    int catId = ((GenericIntStringItem)this.cbCategory.SelectedItem).IntVal;

                    int mediaId =
                        bl.CreateMedia(this.mediaTypeId, this.txtTitle.Text, this.txtDesc.Text, catId);

                    if (this.mediaIdContainer != null)
                    {
                        this.mediaIdContainer.IntVal = mediaId;
                    }

                    // success message
                    Tools.ShowMessageBox(MessageBoxType.Info,
                        Localization.MsgCommonInfoCreationSuccess,
                        this);

                    // close the form
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    Tools.ShowMessageBox(MessageBoxType.Error,
                        Localization.MsgCommonMissingValues,
                        this);
                }
            }
            finally
            {
                this.butAdd.Enabled = true;
            }
        }

        #endregion

        /// <summary>
        /// Form is loading
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMediaAdd_Load(object sender, EventArgs e)
        {
            FillMediaType();
            FillCategories();
        }

        /// <summary>
        /// Add button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butAdd_Click(object sender, EventArgs e)
        {
            AddMedia();
        }

    }
}
