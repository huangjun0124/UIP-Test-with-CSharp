using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Controller;
using Microsoft.ApplicationBlocks.UIProcess;

namespace UIPTest
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
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            
            //Application.Run(new Client.StartMeUp());


            UIPTask task = new UIPTask();
            UIPManager.StartOpenNavigationTask("FormTest", "Main", task);
            Application.Run();
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            // show the error message to the user and exit the application			
            MessageBox.Show(e.Exception.Message);
            Application.Exit();
        }
    }
}
