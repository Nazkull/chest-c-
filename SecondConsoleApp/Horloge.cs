namespace SecondConsoleApp;

public class Horloge
{
    public TimeSpan InitialTime { get; set; }
    public TimeSpan Increment { get; set; }
    public TimeSpan WhiteRemainingTime { get; set; }
    public TimeSpan BlackRemainingTime { get; set; }
    public bool IsRunning { get; set; }

    public Horloge(TimeSpan initialTime, TimeSpan increment)
    {
        InitialTime = initialTime;
        Increment = increment;
        WhiteRemainingTime = initialTime;
        BlackRemainingTime = initialTime;
    }

    public void Start(Couleur color)
    {
        IsRunning = true;
    }

    public void Stop()
    {
        IsRunning = false;
    }

    public void Tick(TimeSpan delta)
    {
        if (!IsRunning)
        {
            return;
        }
    }
}
