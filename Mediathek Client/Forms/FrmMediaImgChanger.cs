using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using BusinessLogic.Common;
using BusinessLogic;
using System.Drawing.Imaging;

namespace MediathekClient.Forms
{
    /// <summary>
    /// Image changer form
    /// </summary>
    public partial class FrmMediaImgChanger : FrmDlgBase
    {

        #region Fields

        /// <summary>
        /// The current session
        /// </summary>
        protected SessionInfo session = null;

        /// <summary>
        /// Bussines logic handler class
        /// </summary>
        protected BusinessLogicHandler bl = new BusinessLogicHandler();

        /// <summary>
        /// The media ID that is being handled
        /// </summary>
        protected int mediaId;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public FrmMediaImgChanger()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public FrmMediaImgChanger(SessionInfo session, int mediaId)
            : this()
        {
            this.session = session;
            this.mediaId = mediaId;
 
        }

        #endregion

        #region Methods

        /// <summary>
        /// Shows the current image of the media
        /// </summary>
        private void ShowCurrentImage()
        {
            this.pbMediaImg.Image = bl.GetMediaImageAsImg(this.mediaId);
        }

        /// <summary>
        /// Saves the currently displayed image from the picturebox to the database
        /// </summary>
        private void SaveImage()
        {
            try
            {
                byte[] arr;
                if (this.pbMediaImg.Image == null)
                {
                    arr = null;
                }
                else
                {
                    arr =
                           Helper.CreateByteArrayFromImage(this.pbMediaImg.Image, ImageFormat.Jpeg);
                }

                bl.SaveMediaImage(this.mediaId, arr);
            }
            catch (Exception ex)
            {
                // show exception
                Common.Tools.ShowMessageBoxException(ex, this);
            }
        }

        #endregion

        /// <summary>
        /// Button "OK" clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butOk_Click(object sender, EventArgs e)
        {
            // save image for media entry
            SaveImage();

            this.Close();
        }

        /// <summary>
        /// Button "select image" clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butSelImg_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                // get filename
                string path = this.openFileDialog.FileName;

                if (!string.IsNullOrEmpty(path) &&
                    File.Exists(path))
                {
                    this.pbMediaImg.Image = Image.FromFile(path);
                }
            }
        }

        /// <summary>
        /// Button "remove image" clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butReset_Click(object sender, EventArgs e)
        {
            this.pbMediaImg.Image = null;
        }

        /// <summary>
        /// On form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMediaImgChanger_Load(object sender, EventArgs e)
        {
            // load current media image and display it
            ShowCurrentImage();
        }


    }
}
