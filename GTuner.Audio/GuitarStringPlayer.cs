using GTuner.Audio.Interfaces;
using System.IO;
using System.Media;
using System.Threading;
using System.Threading.Tasks;

namespace GTuner.Audio
{
    public class GuitarStringPlayer : ISoundPlayer
    {
        private SoundPlayer _soundPlayer;

        private CancellationTokenSource cts = new CancellationTokenSource();

        public void Play(string resourceName, int frequency)
        {
            //abstract this out for unit testing
            var resourceManager = Properties.Resources.ResourceManager;
            object wavResource = resourceManager.GetObject(resourceName);

            InitialiseSoundPlayer(wavResource);
            PlayWavFile(frequency);
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