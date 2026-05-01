namespace StatePattern.States
{
    internal interface IPlayerState
    {
        void Play(MediaPlayer player);
        void Pause(MediaPlayer player);
        void Stop(MediaPlayer player);
    }
}
