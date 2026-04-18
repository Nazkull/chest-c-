namespace SecondConsoleApp;

public class Partie
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime StartTime { get; private set; }
    public DateTime? EndTime { get; private set; }
    public Echiquier Board { get; set; }
    public Joueur White { get; set; }
    public Joueur Black { get; set; }

    public Partie(Joueur white, Joueur black)
    {
        White = white;
        Black = black;
        Board = new Echiquier();
    }

    public void Start()
    {
        StartTime = DateTime.Now;
    }

    public void End(string result)
    {
        EndTime = DateTime.Now;
        // Enregistrer le résultat de la partie si besoin
    }

    public void UndoMove()
    {
        if (Board.MoveHistory.Count == 0)
        {
            return;
        }

        // Implémentation minimale : supprimer le dernier coup
        Board.MoveHistory.RemoveAt(Board.MoveHistory.Count - 1);
    }
}
