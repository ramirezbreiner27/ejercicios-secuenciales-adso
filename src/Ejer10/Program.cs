// La hipotenusa
double cateto1, cateto2, hipotenusa;
Console.Write("Ingrese el valor del primer cateto: ");
cateto1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese el valor del segundo cateto: ");
cateto2 = Convert.ToDouble(Console.ReadLine());
// proceso
hipotenusa = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));
Console.Write($"el valor de la hipotenusa es: {hipotenusa}");
