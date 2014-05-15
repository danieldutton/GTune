using System;
using GTuner.Audio.Interfaces;
using System.IO;
using System.Media;
using System.Threading;
using System.Threading.Tasks;

namespace GTuner.Audio
{
    public class GuitarNotePlayer : ISoundPlayer
    {
        private readonly IResourceHandler _resourceHandler;
        
        private SoundPlayer _soundPlayer;

        private CancellationTokenSource cts = new CancellationTokenSource();


        public GuitarNotePlayer(IResourceHandler resourceHandler)
        {
            _resourceHandler = resourceHandler;
        }

        public void Play(string resourceName, int loopCount)
        {
            var wavResource = _resourceHandler.GetResource(resourceName);

            if (wavResource == null) throw new ArgumentNullException();

            InitialiseSoundPlayer(wavResource);
            PlayWavFile(loopCount);
        }
       
        private void InitialiseSoundPlayer(object resource)
        {
            _soundPlayer = new SoundPlayer((Stream) resource);
            _soundPlayer.Load();
        }

        private void PlayWavFile(int frequency)
        {
            var task = new Task(()=>
            {
                for (int i = 0; i < frequency; i++)
                {
                    if (cts.IsCancellationRequested)
                        return;

                    _soundPlayer.Play();

                    Thread.Sleep(3000);
                }    
            },cts.Token);
            task.Start();
        }

        public void Stop()
        {
            cts.Cancel();  
            cts = new CancellationTokenSource();            
        }
    }
}