//Del segundo a la hora
int hora, minutos, segundos;
Console.Write("Ingrese los segundos: ");
segundos = Convert.ToInt32(Console.ReadLine());
//proceso
hora = segundos / 3600;
segundos = segundos % 3600;
minutos = segundos / 60;
segundos = segundos % 60;
Console.Write($"La hora es: {hora}:{minutos}:{segundos}");

