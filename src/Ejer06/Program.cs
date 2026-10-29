//Termometro triple
double tempC, tempF, tempK;
Console.Write("Ingrese la temperatura en grados Celsius: ");
tempC = Convert.ToDouble(Console.ReadLine());
//proceso
tempF= tempC*1.8+32;
tempK = tempC + 273.15;
Console.Write($"La temperatura en grados Fahrenheit es: {tempF}");
Console.WriteLine();
Console.Write($"La temperatura en grados Kelvin es: {tempK}");