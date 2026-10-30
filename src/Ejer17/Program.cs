//¿Negocio o pérdida?
double costofabric, precioventa, unidvendidas, ganancia, rentabilidad;
Console.Write("Ingrese el valor de su costo: ");
costofabric=Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese el unidades vendidas del producto: ");
unidvendidas=Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese el valor de su precio de venta: ");
precioventa=Convert.ToDouble(Console.ReadLine());
//proceso
rentabilidad= (precioventa-costofabric)/precioventa *100;
ganancia = (precioventa - costofabric) * unidvendidas;
Console.Write($"la rentabilidad del produto es: {rentabilidad}%");
Console.WriteLine();
Console.Write($"la ganancia del producto es: {ganancia}");

