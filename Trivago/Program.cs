using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trivago
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
<<<<<<< HEAD
            Application.Run(new Forms.ViewCustomers());
=======
            Application.Run(new Forms.ViewWebsite());
>>>>>>> 508e2c6e0d000a0372b6cfce68f7a6080e328278
        }
    }
}
