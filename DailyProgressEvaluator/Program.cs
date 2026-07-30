
Console.Write("Nombre del estudiante: ");
string nombre = Console.ReadLine();

Console.Write("Horas estudiadas de C#: ");
int edad = int.Parse(Console.ReadLine());

Console.Write("Minutos estudiados de inglés: ");
int minutos = int.Parse(Console.ReadLine());

Console.Write("Número de ejercicios terminados: ");
int n_ejercicios = int.Parse(Console.ReadLine());

Console.Write("Calificación obtenida en un quiz, de 0 a 100: ");
int calificacion = int.Parse(Console.ReadLine());

int PedirNumero(string mensaje)
{
    int numero;

    Console.Write(mensaje);

    while (!int.TryParse(Console.ReadLine(), out numero))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error: no es un número válido. Intenta de nuevo.");
        Console.ResetColor();

        Console.Write(mensaje);
    }

    return numero;
}
