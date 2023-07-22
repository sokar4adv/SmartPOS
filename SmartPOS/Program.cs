using SmartPOS.Classes;
using SmartPOS.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPOS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //declerations.userId = -1;
            adoClass.setConnection();
            Application.SetCompatibleTextRenderingDefault(false);
            FormStartUp startUp = new FormStartUp();
            if (startUp.ShowDialog() == DialogResult.OK)
            {
                FormLogIn frmLogIn = new FormLogIn();
                if (frmLogIn.ShowDialog() == DialogResult.OK)
                {
                    Application.EnableVisualStyles();
                    Application.Run(new MainForm());
                }
            }
        }
    }
}
