using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GettingStartedWithRabbitMQ
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //todo: add a command line argument to the program to specify the example to run
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PubSub_Producer());
        }
    }
}
