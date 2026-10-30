//El espejo de tres cifras
int numero, num1, num2, num3, espejo;
Console.Write("Ingrese el numero de tres cifras: ");
numero= Convert.ToInt32(Console.ReadLine());
//proceso
num1 = numero / 100;
num2 = (numero%100)/10;
num3 = numero % 10;
espejo= num3 * 100 + num2 * 10 + num1;
Console.Write($"El espejo del numero es: {espejo}");
