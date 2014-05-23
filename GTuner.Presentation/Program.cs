using GTuner.Audio;
using GTuner.Audio.Interfaces;
using System;
using System.Windows.Forms;

namespace GTuner.Presentation
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            IResourceHandler resourceHandler = new WavResourceHandler();
            var guitarNotePlayer = new GuitarNotePlayer();

            Application.Run(new Display(guitarNotePlayer, resourceHandler));
        }
    }
}
