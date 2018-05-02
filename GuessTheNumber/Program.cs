using System;
using System.Windows.Forms;

namespace kz.tsnproff.GuessTheNumber
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //    Launcher.main(); Console.ReadLine();
            //    Test.main(); Console.ReadLine();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LauncherGUI());


        }
    }
}
