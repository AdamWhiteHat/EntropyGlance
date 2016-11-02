using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntropyGlance
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form mainForm = new MainForm();

            if (
                   args != null
                && args.Length > 0
                && !string.IsNullOrWhiteSpace(args[0])
                && System.IO.File.Exists(args[0])
               )
            {

            }

            Application.Run(mainForm);
        }
    }
}
