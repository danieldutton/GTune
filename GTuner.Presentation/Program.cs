using GTuner.Audio;
using System;
using System.Windows.Forms;
using GTuner.Audio.Interfaces;

namespace GTuner.Presentation
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //Resource Handler
            IResourceHandler resourceHandler = new WavResourceHandler();
            var soundPlayer = new GuitarNotePlayer(resourceHandler);

            Application.Run(new Display(soundPlayer));
        }
    }
}
