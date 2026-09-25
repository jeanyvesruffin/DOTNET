# DOTNET

* Vérification de la version dotnet installé

```sh
dotnet --version
# 10.0.401
```

## Créer, générer et exécuter votre application avec le `CLI.NET`

* Exemple de commande pour créer une `application console` 

```sh
# root projet
dotnet new console
#.
#|-- DOTNET.csproj
#|-- Program.cs
#|-- README.md
#`-- obj
#    |-- DOTNET.csproj.nuget.dgspec.json
#    |-- DOTNET.csproj.nuget.g.props
#    |-- DOTNET.csproj.nuget.g.targets
#    |-- project.assets.json
#    `-- project.nuget.cache
```

> Cette `application console` permet d'afficher Hello World!, depuis le fichier `Program.cs`.

```cs
Console.WriteLine("Hello, World!");
```

## Générer et exécuter votre application

```sh
# Générer
dotnet build
# exécuter
dotnet run
# Affiche Hello, C#!
```

## Manipulation des chaines de caratères interpolation de chaîne

```c#
string message = $"{greeting} {firstName}!";
```

## Combiner des littéraux verbatim et l’interpolation de chaîne

```c#
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");
```

## Les méthodes de classes

* Les méthodes sans état sont également appelées `méthodes statiques`. Exemple `Console.WriteLine()`
* Les méthodes avec état sont également appelées `méthodes d’instance`. Exemple `Random dice = new Random();int roll = dice.Next(1, 7);`

### Création `méthodes d’instance`

```c#
Random dice = new Random();
int roll = dice.Next(1, 7);
```

> Votre code utilise l’objet `dice` comme une variable qui stocke l’état de la classe `Random`. Lorsque vous appelez la méthode `Next()` sur l’objet `dice`, la méthode utilise l’état stocké dans l’objet `dice` pour générer un nombre aléatoire.
> La dernière version du runtime .NET vous permet d’instancier un objet sans avoir à répéter le nom du type (appel du constructeur typé cible). Par exemple, le code suivant crée une instance de la classe `Random` :

### Création `méthodes statique`

```c#
int firstValue = 500;
int secondValue = 600;
int largerValue;
largerValue=Math.Max(firstValue,secondValue);
Console.WriteLine(largerValue);
```

## Les conditions `if`, `else`, `else if` et opérateurs logiques `&&` `||`

[Les conditions `if`, `else`, `else if` et opérateurs logiques `&&` `||`](https://learn.microsoft.com/fr-fr/training/modules/csharp-if-elseif-else/1-introduction)

## Stocker et parcourir des séquences de données à l'aide de tableaux et de l'instruction foreach en C#

### Iteration foreach

```c#
string[] fraudulentOrderIDs = ["A123", "B456", "C789"];

string[] fraudulentOrderIDsoldSyntaxe = { "A123", "B456", "C789" };
fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDsoldSyntaxe[2]}");
Console.WriteLine($"There are {fraudulentOrderIDsoldSyntaxe.Length} fraudulent orders to process.");
Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

foreach (string fraudulentOrderID in fraudulentOrderIDs)
{
    Console.WriteLine(fraudulentOrderID);
}
```

Voir suite sur [https://learn.microsoft.com/fr-fr/training/modules/csharp-for](https://learn.microsoft.com/fr-fr/training/modules/csharp-for)