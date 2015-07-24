using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace automotiveToolsDatabase
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static string loginType;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
            Login login = new Login();
            

            if (login.ShowDialog() == DialogResult.OK)
            {
                if (loginType == "manager")
                {
                    Application.Run(new Manager());
                }
                else if (loginType == "employee")
                {
                    Application.Run(new Employee());
                }
            }
            
        }
    }
}
