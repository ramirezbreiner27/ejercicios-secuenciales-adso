using System.Runtime.InteropServices;
using System.Timers;

int a, b, c;
Console.Write("escriba el valor de A: ");
a=Convert.ToInt32(Console.ReadLine());
Console.Write("escriba el valor de B: ");
b=Convert.ToInt32(Console.ReadLine());
//proceso
c = a;
a = b;
b = c;
//imprimir
Console.Write($"Los valores cambiados son: A:{a} y B:{b}");
Console.WriteLine();
Console.Write($"Los valor iniciales son: A:{b} y B:{a}");


