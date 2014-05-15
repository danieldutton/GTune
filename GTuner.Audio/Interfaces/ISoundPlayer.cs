namespace GTuner.Audio.Interfaces
{
    public interface ISoundPlayer
    {
        void Play(string resourceName, int frequency);

        void Stop();
    }
}
