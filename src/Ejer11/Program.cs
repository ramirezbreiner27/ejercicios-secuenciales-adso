//Viaje, galones y plata
double veloc, tiempo, distancia, rendimiento, preciogalon, galonesnec, costocomb;
Console.Write("ingrese velocidad del vehiculo (km/h): ");
veloc = Convert.ToDouble(Console.ReadLine());
Console.Write("ingrese tiempo de viaje (horas): ");
tiempo = Convert.ToDouble(Console.ReadLine());
Console.Write("ingrese precio del galon de combustible (pesos): ");
preciogalon = Convert.ToDouble(Console.ReadLine());
Console.Write("ingrese el rendimiento del vehiculo (km/galon): ");
rendimiento = Convert.ToDouble(Console.ReadLine());
//calculos
distancia = veloc * tiempo;
galonesnec = distancia / rendimiento;
costocomb = galonesnec * preciogalon;
//resultados
Console.WriteLine($"la distancia recorrida es: {distancia}km");
Console.WriteLine();
Console.WriteLine($"la cantidad de galones necesarios es: {galonesnec} galones");
Console.WriteLine();
Console.WriteLine($"el costo del combustible es: {costocomb} pesos");



