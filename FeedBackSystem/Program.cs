using System;
using System.Windows.Forms;

namespace FeedBackSystem
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
            try { 
                Application.Run(new MainForm());
            }
            catch (Exception Ex)
            {
                Application.Exit();
            }
        }
    }
}
