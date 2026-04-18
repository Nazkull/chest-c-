namespace SecondConsoleApp;

public class Coup
{
    public Position From { get; set; }
    public Position To { get; set; }
    public TypePiece? PromotionType { get; set; }
    public DateTime DateTimeTimestamp { get; set; }
    public Piece? PieceCaptured { get; set; }

    public Coup(Position from, Position to)
    {
        From = from;
        To = to;
        DateTimeTimestamp = DateTime.Now;
    }

    public bool IsCapture()
    {
        return PieceCaptured is not null;
    }

    public bool IsPromotion()
    {
        return PromotionType == TypePiece.Pion && (To.Rank == 0 || To.Rank == 7);
    }

    public string ToAlgebraicNotation()
    {
        return $"{From}->{To}";
    }
}
