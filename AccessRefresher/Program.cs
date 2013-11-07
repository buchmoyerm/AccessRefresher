using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AccessRefresher
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var context = new MyApplicationContext();
            Application.Run(context);
        }
    }
}
