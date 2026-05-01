using StatePattern;
using StatePattern.States;

internal class StoppedState : IPlayerState
{
    public void Play(MediaPlayer player)
    {
        Console.WriteLine($"[Stopped] Playing '{player.Track}'");
        player.State = new PlayingState();
    }

    public void Pause(MediaPlayer player)
    {
        Console.WriteLine("[Stopped] Nothing to pause.");
    }

    public void Stop(MediaPlayer player)
    {
        Console.WriteLine("[Stopped] Already stopped.");
    }
}
