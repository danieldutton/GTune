using GTuner.Audio.Interfaces;
using System;
using System.IO;
using System.Media;
using System.Threading;
using System.Threading.Tasks;

namespace GTuner.Audio
{
    public class GuitarNotePlayer : ISoundPlayer
    {
        private readonly SoundPlayer _soundPlayer;

        private CancellationTokenSource _taskCancelSource;


        public GuitarNotePlayer()
        {
            _soundPlayer = new SoundPlayer();
            _taskCancelSource = new CancellationTokenSource();
        }


        public void Play(object resourceStream)
        {
            if(resourceStream == null)
                throw new ArgumentNullException("resourceStream");

            _soundPlayer.Stream = resourceStream as Stream;

            if (_soundPlayer.Stream != null)
                _soundPlayer.Load();

            PlayWavFile();
        }

        private void PlayWavFile()
        {
            var task = new Task(() => 
                _soundPlayer.Play(), _taskCancelSource.Token);
            
            task.Start();            
        }

        public void Stop()
        {
            _soundPlayer.Stop();
            _soundPlayer.Stream = null;
            _taskCancelSource.Cancel();
            _taskCancelSource = new CancellationTokenSource();
            _soundPlayer.Dispose();
        }
    }

    //ToDo - Abstract to unit test more but only if the app grows in complexity
}