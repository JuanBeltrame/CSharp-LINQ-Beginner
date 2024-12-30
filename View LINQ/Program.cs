using View_LINQ;

var games = new List<Game>
{
    new Game { Title = "The Legend of Zelda", Genre = "Adventure", ReleaseYear = 1986, Rating = 9.5, Price = 60 },
    new Game { Title = "Super Mario Bros.", Genre = "Platformer", ReleaseYear = 1985, Rating = 9.2, Price = 50 },
    new Game { Title = "Elden Ring", Genre = "RPG", ReleaseYear = 2022, Rating = 9.8, Price = 50 },
    new Game { Title = "Stardew Valley", Genre = "Simulation", ReleaseYear = 2016, Rating = 9.0, Price = 15 },
    new Game { Title = "Tetris", Genre = "Puzzle", ReleaseYear = 1984, Rating = 8.9, Price = 10 }
};

// Select
var allGames = games.Select(game => game.Title);
foreach (var title in allGames)
    Console.WriteLine(title);

// Where
var rpgGames = games.Where(game => game.Genre == "RPG");
foreach (var title in rpgGames)
    Console.WriteLine(title.Title);

// Any
var modernGamesExist = games.Any(game => game.ReleaseYear > 2000);
Console.WriteLine($"Are there any modern games? {modernGamesExist}");

// OrderBy
var sortedByYear = games.OrderBy(g => g.ReleaseYear);
foreach (var game in sortedByYear)
    Console.WriteLine($"{game.Title} ({game.ReleaseYear})");