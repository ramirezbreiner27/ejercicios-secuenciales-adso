//Punto de encuentro de dos vehículos
double distanciainicial, v1, v2, tiempoencuentro, distancia1, distancia2;
Console.Write("Ingrese la distancia inicial entre los vehículos (Km): ");
distanciainicial = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese la velocidad del primer vehículo (Km/h): ");
v1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese la velocidad del segundo vehículo (Km/h): ");
v2 = Convert.ToDouble(Console.ReadLine());
//proceso
tiempoencuentro = distanciainicial / (v1 + v2);
distancia1 = v1 * tiempoencuentro;
distancia2 = v2 * tiempoencuentro;
Console.Write($"el tiempo de encuentro es: {tiempoencuentro} horas");
Console.WriteLine();
Console.Write($"la distancia recorrida por el primer vehículo es: {distancia1}Km");
Console.WriteLine();
Console.Write($"la distancia recorrida por el segundo vehículo es: {distancia2}Km");
Console.WriteLine();
