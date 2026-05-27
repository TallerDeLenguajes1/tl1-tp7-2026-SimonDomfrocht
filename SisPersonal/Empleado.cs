namespace EspacioEmpleado;

public enum Cargos
{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}

public class Empleado
{
    private string nombre;
    private string apellido;
    private char estadoCivil;
    private DateTime fechaNac;
    private DateTime ingreso;
    private double sueldo;
    private Cargos cargo;

    public string Nombre
    {
        get => nombre;
        set => nombre = value;
    }

    public string Apellido
    {
        get => apellido;
        set => apellido = value;
    }
    public char EstadoCivil
    {
        get => estadoCivil;
        set => estadoCivil = value;
    }
    public DateTime FechaNacimiento
    {
        get => fechaNac;
        set => fechaNac = value;
    }
    public DateTime FechaIngreso
    {
        get => ingreso;
        set => ingreso = value;
    }

    public double SueldoBasico
    {
        get => sueldo;
        set => sueldo = value;
    }

    public Cargos Cargo
    {
        get => cargo;
        set => cargo = value;
    }

    //para sacar antiguedad
    public int CalcularAntiguedad()
    {
        int antiguedad;

        antiguedad = DateTime.Now.Year - FechaIngreso.Year;

        return antiguedad;
    }

    //para sacar la edad
    public int CalcularEdad()
    {
        int edad;
        edad = DateTime.Now.Year - FechaNacimiento.Year;
        return edad;
    }

    //cuanto le falta para la jubilacion
    public int Jubilacion()
    {
        return 65 - CalcularEdad();
    }
    //calcular salario
    public double calcularSalario()
    {
        double adicional = 0;
        if (CalcularAntiguedad() <= 20)
        {
            adicional += ((SueldoBasico * 0.01) * CalcularAntiguedad());
        }
        else
        {
            adicional += SueldoBasico * 0.25;
        }

        if (Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista)
        {
            adicional += adicional * 0.5;
        }

        if (EstadoCivil == 'C')
        {
            adicional += 150000;
        }

        return SueldoBasico + adicional;
    }
}
