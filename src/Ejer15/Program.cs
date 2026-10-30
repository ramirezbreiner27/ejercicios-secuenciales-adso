//Radiografía de un número de cuatro cifras
using System.Timers;

int numero, unid, decen, cent, miles;

Console.Write("Ingrese un número de cuatro cifras: ");
numero = Convert.ToInt32(Console.ReadLine());
//proceso
unid = numero % 10;
decen = (numero % 100) / 10;
cent = (numero % 1000) / 100;
miles = numero / 1000;

Console.Write($"El valor de las 4 cifras es: unidades es: {unid}, decenas es: {decen}, centenas es: {cent} y miles es: {miles}");

