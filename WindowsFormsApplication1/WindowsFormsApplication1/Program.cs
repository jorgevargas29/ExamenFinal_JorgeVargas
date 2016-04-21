using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;

namespace WindowsFormsApplication1
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        static Form1 form1;
        [STAThread]


        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Thread thr = new Thread(ConsoleInputThreadProc);
            form1 = new Form1();
            thr.Start(form1);
            Application.Run(form1);
        }

        static void ConsoleInputThreadProc(object state)
        {
            Menu.menu();
        }

        

    }
}
