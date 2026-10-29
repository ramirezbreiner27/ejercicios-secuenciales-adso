//El cajero 
int monto, resto, restofinal, bill50, bill20, bill10, bill5;
Console.Write("Ingrese el monto a retirar: ");
monto = Convert.ToInt32(Console.ReadLine());
//proceso
bill50 = monto / 50000;
resto = monto % 50000;
bill20 = resto / 20000;
resto = resto % 20000;
bill10 = resto / 10000;
resto = resto % 10000;
bill5 = resto / 5000;
restofinal = resto % 5000;
Console.Write($"Cantidad total de cada uno de los billetes: bill50= {bill50}, bill20= {bill20}, bill10= {bill10}, bill5= {bill5}, restofinal= {restofinal}");