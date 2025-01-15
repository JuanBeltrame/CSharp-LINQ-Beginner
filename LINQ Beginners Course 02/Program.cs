// LINQ to Objects
int[] arregloEnteros = { 1, 2, 10, 3, 2, 55, 666, 18, 2, 100, 2, 41 };
Complejo[] arregloComplejos = [new Complejo(1, "Patito"), 
                               new Complejo(666, "Diablito"), 
                               new Complejo(5, "Perro")];

// Query Syntax
IEnumerable<int> queryOne = from d in arregloEnteros
                            orderby d
                            select d;

IEnumerable<int> queryTwo = from d in arregloEnteros
                            where d == 2
                            orderby d
                            select d;

IEnumerable<int> queryThree = from d in arregloEnteros
                              where d == 2 || d == 10
                              orderby d
                              select d;



// Print Queries
Console.Write("Query One: ");
foreach (var a in queryOne)
    Console.Write(a);
Console.WriteLine();

Console.Write("Query Two: ");
foreach (var b in queryTwo)
    Console.Write(b);
Console.WriteLine();

Console.Write("Query Three: ");
foreach (var c in queryThree)
    Console.Write(c);


public class Complejo(int Numero, string Cadena)
{
    public int Numero { get; set; } = Numero;
    public string? Cadena { get; set; } = Cadena;

    public override string ToString() =>  $"Numero: {Numero}, Cadena: {Cadena}";
}

