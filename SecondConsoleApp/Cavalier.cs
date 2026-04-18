namespace SecondConsoleApp;

public class Cavalier : Piece
{
    public Cavalier(Couleur couleur, Position startPosition)
        : base(TypePiece.Cavalier, couleur, startPosition)
    {
    }

    public override IEnumerable<Position> GetLegalMoves(Echiquier board)
    {
        return Array.Empty<Position>();
    }

    public override Piece Clone()
    {
        return new Cavalier(Couleur, new Position(CurrentPosition.File, CurrentPosition.Rank));
    }
}
