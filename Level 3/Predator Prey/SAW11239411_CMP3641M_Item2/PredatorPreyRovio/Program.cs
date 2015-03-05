using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PredatorPreyRovio
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
            Startup Home = new Startup();
            Application.Run(Home);
        }
    }
}
