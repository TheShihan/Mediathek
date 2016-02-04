using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MediathekClient.Common
{
    /// <summary>
    /// General tools/utilties and helper methods
    /// </summary>
    public class Tools
    {

        /// <summary>
        /// Show a MessageBox.
        /// </summary>
        /// <param name="mbType">The type of the MessageBox</param>
        /// <param name="text">The text that is being displayed inside the MessageBox</param>
        /// <param name="owner">The owner of the MessageBox.</param>
        public static DialogResult ShowMessageBox(MessageBoxType mbType, string text, IWin32Window owner)
        {
            MessageBoxIcon mbIcon;
            MessageBoxButtons mbButtons;
            string caption;

            switch (mbType)
            {
                case MessageBoxType.Error:
                    mbIcon = MessageBoxIcon.Error;
                    mbButtons = MessageBoxButtons.OK;
                    caption = Localization.CtrlMbCaptionError;
                    break;
                case MessageBoxType.Info:
                    mbIcon = MessageBoxIcon.Information;
                    mbButtons = MessageBoxButtons.OK;
                    caption = Localization.CtrlMbCaptionInfo;
                    break;
                case MessageBoxType.Question:
                    mbIcon = MessageBoxIcon.Question;
                    mbButtons = MessageBoxButtons.YesNo;
                    caption = Localization.CtrlMbCaptionQuestion;
                    break;
                case MessageBoxType.Warning:
                    mbIcon = MessageBoxIcon.Warning;
                    mbButtons = MessageBoxButtons.YesNo;
                    caption = Localization.CtrlMbCaptionWarning;
                    break;
                default:
                    mbIcon = MessageBoxIcon.None;
                    mbButtons = MessageBoxButtons.OK;
                    caption = string.Empty;
                    break;
            }

            // display messagebox
            return MessageBox.Show(owner, text, caption, mbButtons, mbIcon, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// Show a MessageBox with exception information.
        /// </summary>
        /// <param name="ex">The exception for which you want to display error information.</param>
        /// <param name="owner">The owner of the MessageBox.</param>
        public static void ShowMessageBoxException(Exception ex, IWin32Window owner)
        {
            ShowMessageBox(MessageBoxType.Error, ex.Message, owner);
        }


    }
}
