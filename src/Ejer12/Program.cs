//Ivertir el numero
int numero ,invertido=0, digito;
Console.Write("Ingrese un numero: ");
numero = Convert.ToInt32(Console.ReadLine());
// proceso

while (numero > 0)
{
    digito = numero % 10;
    invertido = invertido * 10 + digito;
    numero = numero / 10;
}
Console.Write($"El numero invertido es: {invertido}");

