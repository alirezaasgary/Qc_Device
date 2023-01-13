using Qc_Lab.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qc_Lab
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
            //Application.Run(new frm_Login());

            frm_Login fLogin = new frm_Login();
            if (fLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new main());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
