
// TAbla de multiplicar

/*
Console.Write("Colocar numero de la tabla");
int numero = Convert.ToInt32(Console.ReadLine());
List<int> num_tabla = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var squarenumbers =  from num in num_tabla select num * numero;

foreach (var num in squarenumbers)
{
    Console.WriteLine(num);
}
*/





List<string> nom_tabla = new List<string> {"Carlos", "Maria", "Alvarez", "bACA"};

var squareSTRING =  from  nombre_tabla in nom_tabla orderby nombre_tabla select nombre_tabla;

foreach (var nom in squareSTRING)
{
    Console.WriteLine(nom);
}
