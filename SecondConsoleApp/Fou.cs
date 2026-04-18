namespace SecondConsoleApp;

public class Fou : Piece
{
    public Fou(Couleur couleur, Position startPosition)
        : base(TypePiece.Fou, couleur, startPosition)
    {
    }

    public override IEnumerable<Position> GetLegalMoves(Echiquier board)
    {
        return Array.Empty<Position>();
    }

    public override Piece Clone()
    {
        return new Fou(Couleur, new Position(CurrentPosition.File, CurrentPosition.Rank));
    }
}
