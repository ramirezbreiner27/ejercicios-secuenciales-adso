//Ivertir el numero
int numero ,invertido, dig1, dig2;
Console.Write("Ingrese un numero: ");
numero = Convert.ToInt32(Console.ReadLine());

// proceso
dig1 = numero / 10;
dig2 = numero % 10;
invertido = dig2 * 10 + dig1;

Console.Write($"El numero invertido es: {invertido}");

