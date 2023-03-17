using System.Security.Cryptography;
namespace Encapsulacion;
class Program
{
    static void Main(string[] args)
    {
        Persona persona1 = new("Pepito", "Grillo", new DateTime(1973, 4, 15));
        persona1.MostrarInformacion();
    }
}


class Persona
{
    #region Propiedades
    private DateTime fechaNacimiento;

    public string Nombre { get; set; } = "Sin nombre";
    public string Apellidos { get; set; } = "Sin apellidos";
    public string Direccion { get; set; }

    public int Edad
    {
        get
        {
            return (int)(DateTime.Today.Subtract(fechaNacimiento).Days / 365.25);
        }
    }

    #endregion Propiedades

    #region Constructores

    public Persona()
    {
        Nombre = "Sin nombre";
        Apellidos = "Sin apellidos";
        this.fechaNacimiento = DateTime.Today;
    }

    public Persona(string nombre, string apellidos)
    {
        Nombre = nombre;
        Apellidos = apellidos;
    }


    public Persona(string nombre, string apellidos, DateTime fechaNacimento) : this(nombre, apellidos)
    {
        this.fechaNacimiento = fechaNacimento;
    }

    public void MostrarInformacion()
    {
        System.Console.WriteLine($"El nombre es {Nombre} {Apellidos} y tiene {Edad} años.");
    }

    #endregion Constructores

    #region Metodos

    public override string ToString()
    {
        return $@"== Properties ==
        Nombre: {Nombre}
        Apellidos: {Apellidos}
        Fecha Naciemento: {fechaNacimiento}
        Edad: {Edad}
        Dirección: {Direccion}
        ";
    }

    #endregion Metodos
}


class Profesro : Persona
{
    public string Asignatura { get; set; }
    public bool EsJefeDeEstudios { get; set; }
}


class Alumno : Persona
{
    public string[] ListaAsignaturas { get; set; }
    public string Aula { get; set; }

}
