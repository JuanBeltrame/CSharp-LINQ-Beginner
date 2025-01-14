// LINQ to Objects
int[] arregloEnteros = { 1, 2, 10, 3, 2, 55, 666, 18, 2, 100, 2, 41 };


IEnumerable<int> orderedNumbers = from d in arregloEnteros
                                  orderby d
                                  select d;

// Query Syntax
foreach (var a in orderedNumbers)
    Console.WriteLine(a);

