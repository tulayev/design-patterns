using StatePattern;
using StatePattern.States;

internal class PlayingState : IPlayerState
{
    public void Play(MediaPlayer player)
    {
        Console.WriteLine($"[Playing] Already playing '{player.Track}'.");
    }

    public void Pause(MediaPlayer player)
    {
        Console.WriteLine($"[Playing] Paused '{player.Track}'.");
        player.State = new PausedState();
    }

    public void Stop(MediaPlayer player)
    {
        Console.WriteLine($"[Playing] Stopped '{player.Track}'.");
        player.State = new StoppedState();
    }
}
