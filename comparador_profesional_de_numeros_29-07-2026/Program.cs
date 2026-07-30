int numero_1 = PedirNumero("Colocar Numero 1: ");

int numero_2 = PedirNumero("Colocar Numero 2: ");

int numero_3 = PedirNumero("Colocar Numero 3: ");

if (numero_1 > numero_2 && numero_1 > numero_3)
{
    Console.WriteLine("numero 1 es mayor que numero 2 y numero 3");
}
else if (numero_2 > numero_1 && numero_2 > numero_3)
{
    Console.WriteLine("numero 2 es mayor que numero 1 y numero 3");
}
else if (numero_3 > numero_2 && numero_3 > numero_1)
{
    Console.WriteLine("numero 3 es mayor que numero 1 y numero 2");
}
else if (numero_1 == numero_2 && numero_2 > numero_3)
{
    Console.WriteLine("los numeros 1 y 2 son mayores que el 3");
}
else if (numero_1 < numero_2 && numero_2 == numero_3)
{
    Console.WriteLine("los numeros 2 y 3 son mayores que el 1");
}
else if (numero_1 == numero_3 && numero_1 > numero_2)
{
    Console.WriteLine("los numeros 1 y 3 son mayores que el 2");
}
else
{
    Console.WriteLine("los numeros son iguales");
}


int PedirNumero(string mensaje)
{
    int numero;

    Console.Write(mensaje);

    while (!int.TryParse(Console.ReadLine(), out numero))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error: no es un número valido. intenta de nuevo.");
        Console.ResetColor();

        Console.Write(mensaje);
    }

    return numero;
}