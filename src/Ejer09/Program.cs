//Factura
double subtotal, descuento, valordesc, iva, total; 
Console.Write("Ingrese el subtotal: ");
subtotal = Convert.ToDouble(Console.ReadLine());
//proceso
descuento = subtotal * 0.10;
valordesc = subtotal - descuento;
iva = valordesc * 0.19;
total = valordesc + iva;
//salida
Console.Write($"El valor del descuento, iva y total son: {descuento}, {iva} y {total} respectivamente");


