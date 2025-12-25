using System;
using System.Windows.Forms;

namespace Tyuiu.MihajlichenkoSB.Sprint7.Project.V2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
