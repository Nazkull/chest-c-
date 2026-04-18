namespace SecondConsoleApp;

public class Pion : Piece
{
    public Pion(Couleur couleur, Position startPosition)
        : base(TypePiece.Pion, couleur, startPosition)
    {
    }

    public override IEnumerable<Position> GetLegalMoves(Echiquier board)
    {
        return Array.Empty<Position>();
    }

    public override Piece Clone()
    {
        return new Pion(Couleur, new Position(CurrentPosition.File, CurrentPosition.Rank));
    }
}
