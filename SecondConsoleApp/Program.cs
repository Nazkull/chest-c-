using System;

var joueurBlanc = new SecondConsoleApp.Joueur("Alice", SecondConsoleApp.Couleur.Blanc, TimeSpan.FromMinutes(10));
var joueurNoir = new SecondConsoleApp.Joueur("Bob", SecondConsoleApp.Couleur.Noir, TimeSpan.FromMinutes(10));
var partie = new SecondConsoleApp.Partie(joueurBlanc, joueurNoir);
partie.Start();

Console.WriteLine($"Partie créée : {partie.Id}");
Console.WriteLine($"Joueur blanc : {partie.White.Name}");
Console.WriteLine($"Joueur noir : {partie.Black.Name}");
Console.WriteLine("Plateau initialisé avec 64 cases.");
