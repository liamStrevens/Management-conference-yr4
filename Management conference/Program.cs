using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Management_conference.Gui;
namespace Management_conference
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// 
        /// </summary>
        public static Logic.System MainSystem = new Logic.System();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
