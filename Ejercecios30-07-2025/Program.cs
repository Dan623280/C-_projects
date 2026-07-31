// Ejercicio 1
// for (int i=1;i<=100;i++)
// {
//     Console.WriteLine(i);
// }

// Ejercicio 2
// Console.Write("Colocar numero: ");
// int numero = Convert.ToInt32(Console.ReadLine());
//
// for (int i = 0; i <= numero; i+=2)
// {
//     Console.Write(i + " ");
// }

// Ejercicio 3
// Console.WriteLine("Coloca numero: ");
// int numero = Convert.ToInt32(Console.ReadLine());
//
// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine(numero + " * " + i + " = " + numero * i);
// }

// Ejercicio 4
// bool adivino = true;
// do
// {
//     
//     Console.Write("Coloca el numero: ");
//     int n_user = Convert.ToInt32(Console.ReadLine());
//
//     Random rdm = new Random();
//     int n_random = rdm.Next(1,101);
//     if (n_user >= n_random)
//     {
//         Console.WriteLine("el numero es mayor" );
//         Console.WriteLine("random: "+ n_random );
//     }
//     else if (n_user <= n_random)
//     {
//         Console.WriteLine("el numero es menor " );
//         Console.WriteLine("random: "+ n_random );
//     }
//     else
//     {
//         Console.WriteLine("Lo lograste Acertaste el numero");
//         Console.WriteLine("random: "+ n_random );
//         adivino = false;
//         
//     }
// } while (adivino);

// Ejercicio 5
//
// Console.Write("colcoar numero: ");
// int numero = Convert.ToInt32(Console.ReadLine());
// int numer_inicio = 0;
//     
// while (numero != numer_inicio)
// {
//     if (numero % 2 != 0)
//     {
//         Console.WriteLine(numero);
//     }
//     numero--;
// }
//
//     

// Ejercicio 6

// bool verificacion = true;
//
// while (verificacion)
// {
//     Console.Write("Contraseña: ");
//
//     string pasword = Console.ReadLine();
//
//     bool pasword_verefi = pasword == "secreta" ? true : false;
//
//     if (pasword_verefi)
//     {
//         Console.WriteLine("contraseña correcta");
//         verificacion = false;
//     }
//     else
//     {
//         Console.WriteLine("contraseña incorrecta");
//     }
// }

// Ejercicio 7
//
// Console.Write("Colcar numero: ");
// int numero = Convert.ToInt32(Console.ReadLine());
//
// int numero1 = 0;
// int numero2 = 1;
//
// for (int i = 0; i <= numero; i= numero1+numero2)
// {
//         numero1 = numero2;
//         numero2 = i;
//         Console.WriteLine(i);
// }

