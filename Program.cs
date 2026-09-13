using System;
using System.Windows.Forms;
using AluMate.Views;

namespace AluMate
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}