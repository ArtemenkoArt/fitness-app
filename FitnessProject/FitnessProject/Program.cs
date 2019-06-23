using System;
using System.Collections.Generic;
//using System.Linq;
using System.Windows.Forms;

namespace FitnessProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new ServiceForms.FrmLogin());
                Application.Run(new Form1());
            }
            catch (Exception err) { MessageBox.Show(err.Message); }
        }
    }
}
