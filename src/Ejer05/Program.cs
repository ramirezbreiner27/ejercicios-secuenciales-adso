//El circulo
double radio, area, perimetro;
const double PI = 3.1416;
Console.Write("Escriba el radio del círculo: ");
radio = Convert.ToDouble(Console.ReadLine());
area = PI * radio * radio;
perimetro = 2 * PI * radio;
Console.Write($"El área del círculo es: {area}");
Console.WriteLine();
Console.Write($"El perímetro del círculo es: {perimetro}");
