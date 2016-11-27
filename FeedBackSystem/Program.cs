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

            Login login = new FeedBackSystem.Login();
            if(login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm());
            } else
            {
                Application.Exit();
            }
            
        }
    }
}
