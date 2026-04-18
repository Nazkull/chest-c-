namespace SecondConsoleApp;

public class Roi : Piece
{
    public Roi(Couleur couleur, Position startPosition)
        : base(TypePiece.Roi, couleur, startPosition)
    {
    }

    public override IEnumerable<Position> GetLegalMoves(Echiquier board)
    {
        return Array.Empty<Position>();
    }

    public override Piece Clone()
    {
        return new Roi(Couleur, new Position(CurrentPosition.File, CurrentPosition.Rank));
    }
}
