using GTuner.Audio;
using System;
using System.Windows.Forms;
using GTuner.Audio.Interfaces;

namespace GTuner.Presentation
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
            var soundPlayer = new GuitarStringPlayer();

            Application.Run(new Form1(soundPlayer));
        }
    }
}
