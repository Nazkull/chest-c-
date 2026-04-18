namespace SecondConsoleApp;

public class ReglesPartie
{
    public bool AllowEnPassant { get; set; }
    public bool AllowCastling { get; set; }
    public Dictionary<Couleur, bool> InCheck { get; set; } = new()
    {
        { Couleur.Blanc, false },
        { Couleur.Noir, false }
    };

    public bool IsMoveLegal(Echiquier board, Coup move)
    {
        return false;
    }

    public bool IsCheckmate(Echiquier board, Couleur couleur)
    {
        return false;
    }

    public bool IsStalemate(Echiquier board, Couleur couleur)
    {
        return false;
    }
}
