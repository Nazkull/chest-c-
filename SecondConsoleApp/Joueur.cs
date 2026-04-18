namespace SecondConsoleApp;

public class Joueur
{
    public string Name { get; set; }
    public Couleur Couleur { get; set; }
    public TimeSpan RemainingTime { get; set; }
    public bool IsHuman { get; set; }

    public Joueur(string name, Couleur couleur, TimeSpan remainingTime, bool isHuman = true)
    {
        Name = name;
        Couleur = couleur;
        RemainingTime = remainingTime;
        IsHuman = isHuman;
    }

    public void MakeMove(Coup move)
    {
        // Implémenter la logique de choix de coup ici
    }

    public void Resign()
    {
        // Implémenter la démission du joueur
    }
}
