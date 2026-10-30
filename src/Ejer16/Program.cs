//Nómina con horas extra
double horastrabajadas, horasextra, horasbase, valorhora, valorextra, pagoextras, salarioBase, salariototal;
Console.Write("Ingrese las horas trabajadas: ");
horastrabajadas=Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese el valor de la hora: ");
valorhora=Convert.ToDouble(Console.ReadLine());

//proceso
horasbase = 160;
salarioBase=horasbase * valorhora;
horasextra = horastrabajadas - horasbase;
valorextra= valorhora * 1.25;
pagoextras= horasextra * valorextra;
salariototal= salarioBase + pagoextras;
Console.Write($"El salario base es: {salarioBase}");
Console.WriteLine();
Console.Write($"El pago por horas extra es: {pagoextras}");
Console.WriteLine();
Console.Write($"El salario total es: {salariototal}");
