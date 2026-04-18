namespace SecondConsoleApp;

public abstract class Piece
{
    public TypePiece Type { get; protected set; }
    public Couleur Couleur { get; protected set; }
    public bool HasMoved { get; protected set; }
    public Position CurrentPosition { get; protected set; }

    protected Piece(TypePiece type, Couleur couleur, Position startPosition)
    {
        Type = type;
        Couleur = couleur;
        CurrentPosition = startPosition;
    }

    public abstract IEnumerable<Position> GetLegalMoves(Echiquier board);

    public virtual void MoveTo(Position pos)
    {
        CurrentPosition = pos;
        HasMoved = true;
    }

    public abstract Piece Clone();
}
