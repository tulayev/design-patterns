using StatePattern.States;

namespace StatePattern
{
    internal class MediaPlayer
    {
        public string Track { get; set; } = "Unknown";
        public IPlayerState State { get; set; }

        public MediaPlayer()
        {
            State = new StoppedState();
        }

        public void Play()
        {
            State.Play(this);
        }

        public void Pause()
        {
            State.Pause(this);
        }

        public void Stop()
        {
            State.Stop(this);
        }
    }
}