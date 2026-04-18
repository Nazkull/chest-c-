namespace SecondConsoleApp;

public class Reine : Piece
{
    public Reine(Couleur couleur, Position startPosition)
        : base(TypePiece.Reine, couleur, startPosition)
    {
    }

    public override IEnumerable<Position> GetLegalMoves(Echiquier board)
    {
        return Array.Empty<Position>();
    }

    public override Piece Clone()
    {
        return new Reine(Couleur, new Position(CurrentPosition.File, CurrentPosition.Rank));
    }
}
