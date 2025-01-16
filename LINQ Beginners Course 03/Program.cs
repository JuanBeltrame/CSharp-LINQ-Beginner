//------------------- LINQ to Objects -------------------
var beers = new List<Beer> {
    new Beer { Name = "Sin Alcohol", brand = "Quilmes", AlcoholByVolume = 5.2, BreweryId = 1 },
    new Beer { Name = "IPA", brand = "Brahama", AlcoholByVolume = 4.9, BreweryId = 1 },
    new Beer { Name = "Negra", brand = "Stella Artois", AlcoholByVolume = 6.6, BreweryId = 1 },
    new Beer { Name = "Roja", brand = "Heineken", AlcoholByVolume = 9.0, BreweryId = 2 },
    new Beer { Name = "Rubia", brand = "Andes Origen", AlcoholByVolume = 8.5, BreweryId = 2 },
    };


//------------------- Query Syntax -------------------
var breweries = from d in beers
                select d.Name;

var breweries2 = from d in beers
                 select new { d.Name, d.brand };

var breweires3 = from b in beers
                 where b.brand == "Quilmes"
                 select new { b.Name, b.brand };


//------------------- Display Queries -------------------
foreach (var a in breweries)
    Console.WriteLine(a);
Console.WriteLine();

foreach (var item in breweries2)
    Console.WriteLine(item.brand);

foreach (var item in breweires3)
    Console.WriteLine(item.brand);


public class Beer
{
    public string Name { get; set; }
    public string brand { get; set; }
    public double AlcoholByVolume { get; set; }
    public int BreweryId { get; set; }
}
