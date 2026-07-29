// Ejercicio 1
// Console.Write("Colocar numero: ");
// int numero = int.Parse(Console.ReadLine());
//
// if (numero % 2 == 0)
// {
//     Console.WriteLine("El numero es par");
// }
// else
// {
//     Console.WriteLine("El numero es impar");
// }



//Ejercicio 2
// Console.Write("Colocar nombre: ");
// string nombre = Console.ReadLine();
//
// if (nombre == null)
// {
//     Console.WriteLine("El nombre es nulo");
// }
// else if (nombre.Length == 0)
// {
//     Console.WriteLine("El nombre esta vacio");
// }
// else
// {
//     Console.WriteLine("El nombre es " + nombre);
// }



//Ejercicio 3
// Console.Write("Colocar edad: ");
// int edad = int.Parse(Console.ReadLine());
//
// if (edad is >= 18 and <= 100)
// {
//     Console.WriteLine("mayor de edad");
// }
// else if (edad is < 18 and > 0)
// {
//     Console.WriteLine("menor de edad");
// }
// else
// {
//     Console.WriteLine("edad no valida");
// }



//Ejercicio 4
// Console.Write("Colocar dia de la semana: ");
// int dia = int.Parse(Console.ReadLine());
//
// switch (dia)
// {
//     case 1:
//         Console.WriteLine("El dia de la semana es lunes");
//         break;
//     case 2:
//         Console.WriteLine("El dia de la semana es martes");
//         break;
//     case 3:
//         Console.WriteLine("El dia de la semana es miercoles");
//         break;
//     case 4:
//         Console.WriteLine("El dia de la semana es jueves");
//         break;
//     case 5:
//         Console.WriteLine("El dia de la semana es viernes");
//         break;
//     case 6:
//         Console.WriteLine("El dia de la semana es sabado");
//         break;
//     case 7:
//         Console.WriteLine("El dia de la semana es domingo");
//         break;
//     default:
//         Console.WriteLine("Opción no válida.");
//         break;
// }



//Ejercicio 5
// Console.Write("Colocar nacionalidad: ");
// string nacionalidad = Console.ReadLine();
// string tipo = (nacionalidad == "colombiana" ? "colombiana" : "extranjera");
// Console.Write($"su nacionalidad es {tipo}");



//Ejercicio 6
// Console.Write("Colocar numero 1: ");
// int numero1 = int.Parse(Console.ReadLine());
//
// Console.Write("Colocar numero 2: ");
// int numero2 = int.Parse(Console.ReadLine());
//
// Console.Write("Colocar numero 3: ");
// int numero3 = int.Parse(Console.ReadLine());
//
// if (numero1 > numero2 && numero1 > numero3)
// {
//     Console.WriteLine("El numero 1 es mayor que numero 2 y numero 3");
// }
// else if (numero2 > numero1 && numero2 > numero3)
// {
//     Console.WriteLine("El numero 1 es mayor que numero 2 y numero 3");
// }
// else if (numero3 > numero1 && numero3> numero2)
// {
//     Console.WriteLine("El numero 3 es mayor que numero 1 y numero 2");
// }
// else
// {
//     Console.WriteLine("los numeros son iguales");
// }



// Ejercicio 7
// Console.Write("Colocar Contraseña: ");
// string contrasena = Console.ReadLine();
//
// if (contrasena == null || contrasena.Contains(" ") == true)
// {
//     Console.WriteLine("El contrasena es nulo");
// }
// else if (contrasena.Length == 0)
// {
//     Console.WriteLine("El contrasena esta vacio");
// }
// else
// {
//     Console.WriteLine("El contrasena es valida");
// }



// Ejeercicio 8
// Console.Write("Colocar el numero del mes: ");
// int mes = int.Parse(Console.ReadLine());
//
// switch (mes)
// {
//     case 1:
//         Console.WriteLine("Enero");
//         break;
//     case 2:
//         Console.WriteLine("Febrero");
//         break;
//     case 3:
//         Console.WriteLine("Marzo");
//         break;
//     case 4:
//         Console.WriteLine("Abril");
//         break;
//     case 5:
//         Console.WriteLine("Mayo");
//         break;
//     case 6:
//         Console.WriteLine("Junio");
//         break;
//     case 7:
//         Console.WriteLine("Julio");
//         break;
//     case 8:
//         Console.WriteLine("Agosto");
//         break;
//     case 9:
//         Console.WriteLine("Septiembre");
//         break;
//     case 10:
//         Console.WriteLine("Octubre");
//         break;
//     case 11:
//         Console.WriteLine("Noviembre");
//         break;
//     case 12:
//         Console.WriteLine("Diciembre");
//         break;
//     default:
//         Console.WriteLine("Opción no válida.");
//         break;
// }

// Ejercicio 9
// Console.Write("ColocaR Calificacion: ");
// int calificacion = int.Parse(Console.ReadLine());
//
// if (calificacion >= 1 && calificacion < 20)
// {
//     Console.WriteLine("El calificacion es A");
// }
// else if (calificacion >= 20 && calificacion < 40)
// {
//     Console.WriteLine("El calificacion es B");
// }
// else if (calificacion >= 40 && calificacion < 60)
// {
//     Console.WriteLine("El calificacion es C");
// }
// else if (calificacion >= 60 && calificacion < 80)
// {
//     Console.WriteLine("El calificacion es D");
// }
// else if (calificacion >= 80 && calificacion < 100)
// {
//     Console.WriteLine("El calificacion es F");
// }
// else
// {
//     Console.WriteLine("El calificacion no valida");
// }
//



// Ejercicio 10
// Console.Write("Escriba un caracter: ");
// char caracter = char.ToUpper(Convert.ToChar(Console.ReadLine()));
//
// switch (caracter)
// {
//     case 'A' or 'E' or 'I' or 'O' or 'U':
//         Console.WriteLine("es una vocal");
//         break;
//     default:
//         Console.WriteLine("No es una vocal");
//         break;
// }



// Ejercicio 11
// Console.Write("Colocar primer numero: ");
// int numero1 = int.Parse(Console.ReadLine());
// Console.Write("Colocar segundo numero: ");
// int numero2 = int.Parse(Console.ReadLine());
//
// if (numero1 == numero2)
// {
//     Console.WriteLine("son iguales los numeros");
// }
// else
// {
//     Console.WriteLine("son diferentes los numeros");
// }



// Ejercicio 12
// Console.Write("Colocar Direccion: ");
// string direccion = Console.ReadLine();
//
// if (direccion == null || direccion.Contains(" ") == true)
// {
//     Console.WriteLine("El direccion es nulo");
// }
// else if (direccion.Length == 0)
// {
//     Console.WriteLine("El direccion esta vacio");
// }
// else
// {
//     Console.WriteLine("El direccion es valida");
// }

// Ejercicio 13
// Console.Write("Colocar numero: ");
// int numero = int.Parse(Console.ReadLine());
//
// if (numero > 0)
// {
//     Console.Write("Numero es Positivo");
// }
// else if (numero < 0)
// {
//     Console.Write("Numero es Negativo");
// }
// else
// {
//     Console.Write("Numero es 0");
// }

// Ejercicio 14
// Console.Write("Escriba un caracter: ");
// char caracter = char.ToUpper(Convert.ToChar(Console.ReadLine()));
//
// if (caracter is 'A' or 'E' or 'I' or 'O' or 'U')
// {
//     Console.WriteLine("es una vocal");
// }
// else
// {
//     Console.WriteLine("no es una vocal");
// }
//

// Ejercicio 15
// Console.Write("Colocar Temperatura: ");
// int temperatura = int.Parse(Console.ReadLine());
//
// if (temperatura > 30)
// {
//     Console.Write("caliente");
// }
// else if (temperatura is > 10 and <30  )
// {
//     Console.Write("Templada");
// }
// else
// {
//     Console.Write("fria");
// }


//ejercicio 16
// Console.Write("Colocar año: ");
// int año = int.Parse(Console.ReadLine());
// bool esBisiesto = DateTime.IsLeapYear(año);
//
// if (esBisiesto)
// {
//     Console.WriteLine("Bisiesto");
// }
// else
// {
//     Console.WriteLine("no es Bisiesto");
// }



// Ejercicio 17
// Console.Write("Colocar valor: ");
// string valor = Console.ReadLine();
//
// if (valor == null || valor.Contains(" ") == true)
// {
//     Console.WriteLine("El valor es nulo");
// }
// else if (valor.Length == 0)
// {
//     Console.WriteLine("El valor esta vacio");
// }
// else
// {
//     Console.WriteLine("El valor es valida");
// }

// Ejercicio 18
// Console.Write("Colocar dia de la semana: ");
// int dia = int.Parse(Console.ReadLine());
//
// switch (dia)
// {
//     case 1:
//         Console.WriteLine("laborable");
//         break;
//     case 2:
//         Console.WriteLine("laborable");
//         break;
//     case 3:
//         Console.WriteLine("laborable");
//         break;
//     case 4:
//         Console.WriteLine("laborable");
//         break;
//     case 5:
//         Console.WriteLine("laborable");
//         break;
//     case 6:
//         Console.WriteLine("fin de semana");
//         break;
//     case 7:
//         Console.WriteLine("fin de semana");
//         break;
//     default:
//         Console.WriteLine("Opción no válida.");
//         break;
// }




