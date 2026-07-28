// Ejercicio1
// Console.WriteLine("¡Hola, mundo!");


// Ejercicio2
//int numero = 5;
//string texto = "texto";
//Console.WriteLine(texto);
//Console.WriteLine(numero);

// Ejercicio3
//string texto = "teXto";
//string textomayuscula = texto.ToUpper();
//string textominuscula = texto.ToLower();
//Console.WriteLine(texto);
//Console.WriteLine(textomayuscula);
//Console.WriteLine(textominuscula);


//Ejercicio4

//byte numero1 = 5;
//byte numero2 = 6;
//var sumar = (int a, int b) => a + b;
//var restar = (int a, int b) => a - b;
//var multiplicar = (int a, int b) => a * b;
//var dividir = (int a, int b) => b != 0 ? a / b : 0;
//Console.WriteLine(sumar(numero1, numero2));
//Console.WriteLine(restar(numero1, numero2));
//Console.WriteLine(multiplicar(numero1, numero2));
//Console.WriteLine(dividir(numero1, numero2));

//Ejercicio 5
// int numero1 = 6;
// int numero2 = 6;
//lambda 
//var condicional = (int a, int b) => a > b ? "numero a es mayor que b" : a == b ? "numero a es igual a b" : "numero a es menor b";
//Console.WriteLine(condicional(numero1, numero2));
//if ( numero1 == numero2)
//{
//    Console.WriteLine("numero a es mayor que b");
// }
// else if (numero1 > numero2)
// {
//     Console.WriteLine("numer1 es mayor que numero2");
// }
// else if (numero1 < numero2)
// {
//     Console.WriteLine("numer2 es mayor que numero1");
// }
// else
// {
//     Console.WriteLine("hubo un error ");
// }


//Ejercicio 6

// string frase = "El saber no es suficiente, debemos aplicarlo; el querer no es suficiente, debemos actuar";
//
// string palabra = "suficiente";
//
// string remplazar = "maluco";
//
// Console.WriteLine(frase.Replace(palabra, remplazar));



// Ejercicio 7
// Console.Write("Colocar nombre: ");
// string nombre = Console.ReadLine();
//
// Console.Write("Colocar edad: ");
// int edad = int.Parse(Console.ReadLine()); 
//
// Console.WriteLine(" ");
// Console.WriteLine($"nombre: {nombre}");
// Console.WriteLine($"edad: {edad}");   



//Ejercicio 8

// int numero1 = 12;
//     
// if ( numero1 == 10)
// {
//     Console.WriteLine("numero a es igual que 10");
//  }
// else if (numero1 > 10)
// {
//      Console.WriteLine("numero es mayor que 10");
// }
// else if (numero1 < 10)
// {
//      Console.WriteLine("numero es menor que 10");
// }
// else
// {
//      Console.WriteLine("hubo un error ");
// }


//Ejercicio 9


// double numero1 = 5.5;
// double numero2 = 6.7;
// var sumar = (double a, double b) => a + b;
// var restar = (double a, double b) => a - b;
// var multiplicar = (double a, double b) => a * b;
// var dividir = (double a, double b) => b != 0 ? a / b : 0;
// Console.WriteLine(sumar(numero1, numero2));
// Console.WriteLine(restar(numero1, numero2));
// Console.WriteLine(multiplicar(numero1, numero2));
// Console.WriteLine(dividir(numero1, numero2));

// Ejercicio10
// string texto_1 = "hola";
// string texto_2 = "_dora";
// string texto_3 = texto_1 + texto_2;
// Console.WriteLine(texto_3);


//Ejercicio11

// int edad = 15; 
// double numero = double.Parse(edad.ToString());
// Console.WriteLine(edad);
// Console.WriteLine(numero);
// Console.WriteLine(edad.GetType());
// Console.WriteLine(numero.GetType());

//Ejercicio12
//
// Console.Write("Colocar un numero: ");
// int numero = int.Parse(Console.ReadLine());
//
// if (numero > 0)
// {
//     Console.Write("positivo");
// }
// else if (numero < 0)
// {
//     Console.Write("negativo");
// }
// else
// {
//     Console.Write("el numero es 0");
// }

//ejercicio13
// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine(i);
// }

//ejercicio14
// string caracteres = " buenas dias señor porras ";
// caracteres = caracteres.Trim();
// caracteres  = char.ToUpper(caracteres[0])+ caracteres.Substring(1);
// Console.WriteLine(caracteres);

//Ejercicio15
// Console.Write("Colocar numero de la tabla: ");
// int numero = int.Parse(Console.ReadLine());
//
// for (int i = 0; i <= 10; i++)
// {
//     Console.WriteLine($"{numero} * {i} = {numero * i}");
// }

//Ejercicio 16

// string palabra1 = "Palabra 1";
// string palabra2 = "Palabra 2";
//
// string palabra3 = palabra1 + palabra2;
//
// Console.WriteLine(palabra1.Length);
// Console.WriteLine(palabra2.Length);
//
// Console.WriteLine(palabra3);

//Ejercicio 17
//
// string cadena = "Este es un string";
//
// Console.WriteLine(cadena.Substring(11).Length);