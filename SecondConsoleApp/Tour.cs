namespace SecondConsoleApp;

public class Tour : Piece
{
    public Tour(Couleur couleur, Position startPosition)
        : base(TypePiece.Tour, couleur, startPosition)
    {
    }

    public override IEnumerable<Position> GetLegalMoves(Echiquier board)
    {
        return Array.Empty<Position>();
    }

    public override Piece Clone()
    {
        return new Tour(Couleur, new Position(CurrentPosition.File, CurrentPosition.Rank));
    }
}
