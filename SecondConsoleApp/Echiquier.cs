namespace SecondConsoleApp;

public class Echiquier
{
    public Case[,] Squares { get; set; } = new Case[8, 8];
    public List<Coup> MoveHistory { get; set; } = new();
    public int FullMoveCount { get; set; }
    public bool IsFlipped { get; set; }

    public Echiquier()
    {
        Initialize();
    }

    public void Initialize()
    {
        for (var file = 0; file < 8; file++)
        {
            for (var rank = 0; rank < 8; rank++)
            {
                Squares[file, rank] = new Case(new Position(file, rank));
            }
        }
    }

    public void ApplyMove(Coup move)
    {
        var fromCase = GetCase(move.From);
        var toCase = GetCase(move.To);

        if (fromCase?.PieceOccupant is null || toCase is null)
        {
            return;
        }

        move.PieceCaptured = toCase.PieceOccupant;
        toCase.PlacePiece(fromCase.PieceOccupant);
        fromCase.RemovePiece();
        MoveHistory.Add(move);
    }

    public Piece? GetPieceAt(Position pos)
    {
        return GetCase(pos)?.PieceOccupant;
    }

    public Case? GetCase(Position pos)
    {
        if (!pos.IsValid())
        {
            return null;
        }

        return Squares[pos.File, pos.Rank];
    }
}
