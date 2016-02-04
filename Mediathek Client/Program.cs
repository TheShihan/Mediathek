using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MediathekClient.Forms;

namespace MediathekClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // show logon dialog
            new FrmLogin().Show();

            // start the application (and message queue)
            Application.Run();
        }
    }
}
