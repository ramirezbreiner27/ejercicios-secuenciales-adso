//definimos variables
int a, b;
Console.Write("Escriba el valor de A: ");
a=Convert.ToInt32(Console.ReadLine());
Console.Write("Escriba el valor de B: ");
b=Convert.ToInt32(Console.ReadLine());
//proceso
a = a+b;
b = a-b;
a = a-b;
Console.WriteLine($"Los valores cambiados son: A {a} y B {b}");
