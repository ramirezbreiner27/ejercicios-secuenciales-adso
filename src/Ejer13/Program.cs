//Sumatoria de digitos de 3 cifras
int numero, suma, dig1, dig2, dig3;
Console.Write("Ingrese un número de 3 cifras: ");
numero = Convert.ToInt32(Console.ReadLine());
dig1 = numero / 100;
dig2 = (numero % 100) / 10;
dig3 = numero % 10;
suma = dig1 + dig2 + dig3;
Console.Write($"La sumatoria de los dígitos es: {suma}");