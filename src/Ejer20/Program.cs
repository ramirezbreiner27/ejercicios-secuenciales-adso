// 
double capital, tasa, meses, capitalfinal, intereses;
Console.Write("Ingrese el capital inicial:");
capital = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese la tasa de interés:");
tasa = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese el número de meses:");
meses = Convert.ToDouble(Console.ReadLine());
//proceso
capitalfinal= capital * Math.Pow(1+tasa/100, meses);
intereses= capitalfinal - capital;
Console.Write($"El capital final es: {capitalfinal}");
Console.WriteLine();
Console.Write($"El interes final es: {intereses}");
