# Jeu d'Échecs C#

Un squelette de jeu d'échecs implémenté en C# avec .NET 10.0.

## Structure du Projet

### Classes Principales
- **Piece** : Classe abstraite de base pour toutes les pièces
- **Echiquier** : Représente le plateau de jeu 8x8
- **Partie** : Gère une partie complète d'échecs
- **Joueur** : Représente un joueur humain ou IA
- **Coup** : Représente un mouvement sur l'échiquier

### Pièces Implémentées
- **Roi** (King)
- **Reine** (Queen)
- **Tour** (Rook)
- **Fou** (Bishop)
- **Cavalier** (Knight)
- **Pion** (Pawn)

### Classes Utilitaires
- **Position** : Coordonnées (x,y) sur l'échiquier
- **Case** : Case individuelle du plateau
- **Horloge** : Gestion du temps de jeu
- **ReglesPartie** : Règles et validation des mouvements

## Compilation et Exécution

### Prérequis
- .NET 10.0 SDK
- Git (pour le versioning)

### Compiler le projet
```bash
cd SecondConsoleApp
dotnet build
```

### Exécuter le programme
```bash
dotnet run --project SecondConsoleApp/SecondConsoleApp.csproj
```

## État du Développement

Ce projet contient actuellement :
- ✅ Squelette complet des classes selon l'UML
- ✅ Structure hiérarchique des pièces
- ✅ Gestion de base des positions et mouvements
- ✅ Compilation réussie
- ⏳ Logique de mouvement à implémenter
- ⏳ Interface utilisateur à développer
- ⏳ Règles de jeu complètes à implémenter

## Technologies Utilisées

- **Langage** : C# 12
- **Framework** : .NET 10.0
- **IDE** : Visual Studio Code / Visual Studio
- **Versioning** : Git

## Contribution

Ce projet est en développement actif. Les contributions sont les bienvenues !

## Licence

Ce projet est sous licence MIT.