//El triangulo que crece
double altura, baseT, area, area1, perimetro, perimetro1;
Console.Write("Ingrese la altura del triangulo: ");
altura = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese la base del triangulo: ");
baseT = Convert.ToDouble(Console.ReadLine());
//proceso
area = (baseT * altura) / 2;
perimetro = 3 * baseT;
area1 = Math.Pow(baseT, 2) * Math.Pow(altura, 3) / 2;
perimetro1 = 3 * Math.Pow(baseT, 2);
//imprimir resultados
Console.Write($"El area y perimetro del triangulo es: A: {area} y P: {perimetro}");
Console.WriteLine();
Console.Write($"El area duplicada y perimetro triplicado del triangulo que crece es: A: {area1} y P: {perimetro1}");