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
            //todo: teste com docker
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PubSub_Producer());
        }
    }
}
