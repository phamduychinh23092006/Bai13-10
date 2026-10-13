using System;
using System.Windows.Forms;


namespace StudentManagerApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Khởi chạy Form chính MDI Parent
            Application.Run(new FormMain());
        }
    }
}