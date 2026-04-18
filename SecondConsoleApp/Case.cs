namespace SecondConsoleApp;

public class Case
{
    public Position Pos { get; set; }
    public Piece? PieceOccupant { get; set; }
    public bool IsHighlighted { get; set; }

    public Case(Position pos)
    {
        Pos = pos;
    }

    public bool IsEmpty()
    {
        return PieceOccupant is null;
    }

    public void PlacePiece(Piece piece)
    {
        PieceOccupant = piece;
        piece.MoveTo(Pos);
    }

    public void RemovePiece()
    {
        PieceOccupant = null;
    }
}
