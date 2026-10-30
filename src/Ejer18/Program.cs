//Pintura y latas
double m2pintar, rendimiento, litroslatas, latascompletas, litrossueltos, litrosnec;
Console.Write("Escriba los metros cuadrados a pintar: ");
m2pintar = Convert.ToDouble(Console.ReadLine());
Console.Write("Escriba el rendimiento (m2 por litro): ");
rendimiento = Convert.ToDouble(Console.ReadLine());
Console.Write("Escriba los litros de cada lata: ");
litroslatas = Convert.ToDouble(Console.ReadLine());
// proceso
litrosnec = m2pintar / rendimiento;
latascompletas = Math.Floor (litrosnec / litroslatas);
litrossueltos = litrosnec - (latascompletas * litroslatas);
Console.WriteLine($"Las latas completas usadas son: {latascompletas}");
Console.WriteLine();
Console.Write($"Los litros sueltos son: {litrossueltos}");