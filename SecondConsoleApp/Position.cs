namespace SecondConsoleApp;

public class Position
{
    public int File { get; set; }
    public int Rank { get; set; }

    public Position(int file, int rank)
    {
        File = file;
        Rank = rank;
    }

    public bool IsValid()
    {
        return File >= 0 && File < 8 && Rank >= 0 && Rank < 8;
    }

    public override string ToString()
    {
        return $"{File},{Rank}";
    }
}
