using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ToDoList
{
    static class Program
    {

        public static Home home;
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            home = new Home();
            Application.Run(home);

            
        }
    }
}
