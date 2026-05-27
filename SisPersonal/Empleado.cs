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
    private string estadoCivil;
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
    public string EstadoCivil
    {
        get => estadoCivil;
        set => estadoCivil = value;
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

}
