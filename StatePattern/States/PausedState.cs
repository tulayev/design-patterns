using StatePattern;
using StatePattern.States;

internal class PausedState : IPlayerState
{
    public void Play(MediaPlayer player)
    {
        Console.WriteLine($"[Paused] Resumed '{player.Track}'.");
        player.State = new PlayingState();
    }

    public void Pause(MediaPlayer player)
    {
        Console.WriteLine("[Paused] Already paused.");
    }

    public void Stop(MediaPlayer player)
    {
        Console.WriteLine($"[Paused] Stopped '{player.Track}'.");
        player.State = new StoppedState();
    }
}
