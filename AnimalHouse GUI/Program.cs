using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimaleHouseModel;
using System.Threading;

namespace AnimalHouse_GUI
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
            Application.Run(new AnimalHouseGui_Main());
            //Thread t = new Thread(new ThreadStart(Test));
            //t.Start();
        }
        private static void Test()
        {
            EmailSystem email = new EmailSystem();
            Email mail = new Email();
            bool s = mail.SendEmail("test", "test", "radwawn.alfakseh@gmail.com");
            Console.WriteLine(s);
            Console.ReadLine();
        }

    }
}
