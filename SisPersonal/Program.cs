using EspacioEmpleado;

Empleado[] empleados = new Empleado[3];
//punto c
for (int i = 0; i < 3; i++)
{
    empleados[i] = new Empleado();

    Console.WriteLine("Empleado"+ (i+1));

    Console.WriteLine("Ingrese nombre:");
    empleados[i].Nombre = Console.ReadLine();

    Console.WriteLine("Ingrese apellido:");
    empleados[i].Apellido = Console.ReadLine();

    Console.WriteLine("Ingrese estado civil: S - Soltero / C - Casado");
    empleados[i].EstadoCivil = char.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese sueldo basico:");
    empleados[i].SueldoBasico = double.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese fecha de nacimiento ejemplo: 2000-05-10");
    empleados[i].FechaNacimiento = DateTime.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese fecha de ingreso ejemplo: 2000-05-10");
    empleados[i].FechaIngreso = DateTime.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese cargo:");
    Console.WriteLine("0 - Auxiliar");
    Console.WriteLine("1 - Administrativo");
    Console.WriteLine("2 - Ingeniero");
    Console.WriteLine("3 - Especialista");
    Console.WriteLine("4 - Investigador");

    int opcionCargo = int.Parse(Console.ReadLine());
    empleados[i].Cargo = (Cargos)opcionCargo;

    Console.WriteLine();
}

//Operaciones a mostrar
Console.WriteLine("Antiguedad de los empleados: ");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("-Empleado" + (i + 1));
    Console.WriteLine("Antiguedad: " + empleados[i].CalcularAntiguedad());
}

Console.WriteLine("Edad de los empleados: ");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("-Empleado" + (i + 1));
    Console.WriteLine("Edad: " + empleados[i].CalcularEdad());
}

Console.WriteLine("Cuanto le falta para jubilarse a cada empleado: ");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("-Empleado" + (i + 1));
    Console.WriteLine("Anios restantes para jubilarse: " + empleados[i].Jubilacion());
}

//punto d
double montoTotalSalarios = 0;

for (int i = 0; i < 3; i++)
{
    montoTotalSalarios += empleados[i].calcularSalario();
}

Console.WriteLine("Monto total pagado en salarios: $" + montoTotalSalarios);

//punto e
int indexJubi = 0;

for (int i = 1; i < 3; i++)
{
    if (empleados[i].Jubilacion() < empleados[indexJubi].Jubilacion())
    {
        indexJubi = i;
    }
}

Console.WriteLine("Empleado mas proximo a jubilarse:");

Console.WriteLine("Nombre: " + empleados[indexJubi].Nombre);
Console.WriteLine("Apellido: " + empleados[indexJubi].Apellido);
Console.WriteLine("Estado civil: " + empleados[indexJubi].EstadoCivil);
Console.WriteLine("Fecha de nacimiento: " + empleados[indexJubi].FechaNacimiento.ToShortDateString());
Console.WriteLine("Fecha de ingreso: " + empleados[indexJubi].FechaIngreso.ToShortDateString());
Console.WriteLine("Sueldo basico: $" + empleados[indexJubi].SueldoBasico);
Console.WriteLine("Cargo: " + empleados[indexJubi].Cargo);

Console.WriteLine("Edad: " + empleados[indexJubi].CalcularEdad());
Console.WriteLine("Antiguedad: " + empleados[indexJubi].CalcularAntiguedad());
Console.WriteLine("Anios restantes para jubilarse: " + empleados[indexJubi].Jubilacion());
Console.WriteLine("Salario: $" + empleados[indexJubi].calcularSalario());