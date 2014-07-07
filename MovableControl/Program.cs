using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MovableControl
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// test git extension for edit file 
        /// next change for testing add more comment
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Movalble());
        }
    }
}