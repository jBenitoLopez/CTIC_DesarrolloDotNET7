namespace AbstraccionPolimorfismo;
class Program
{
    static void Main(string[] args)
    {
        // Persona persona = new("Pepito", "Grillo", new DateTime(1973, 4, 15));
        // persona.MostrarInformacion();


        Alumno alumno = new();
        alumno.Nombre = "Alumno1";
        alumno.Apellidos = "Apellidos 1";
        alumno.MostrarInformacion();

        Profesor profesor = new();
        profesor.Nombre = "Profesor1";
        profesor.Apellidos = "Apellidos 2";
        profesor.MostrarInformacion();

        Director director = new();
        director.Nombre = "Director1";
        director.Apellidos = "Apellidos 3";
        director.MostrarInformacion();
    }
}


abstract class Persona
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

    public virtual void MostrarInformacion()
    {
        System.Console.WriteLine($"El nombre es {Nombre} {Apellidos} y tiene {Edad} años.");
    }

    public abstract bool ValidarInformacion();


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


class Profesor : Persona
{
    public string Asignatura { get; set; }
    public bool EsJefeDeEstudios { get; set; }

    public override bool ValidarInformacion()
    {
        return true;
    }

    public override void MostrarInformacion()
    {
        if (ValidarInformacion())
        {
            System.Console.WriteLine($"El nombre del profesor es {Nombre} {Apellidos} y tiene {Edad} años.\nAsignatura: {Asignatura}, Es el Jefe de Estudio: {(EsJefeDeEstudios ? "Si" : "No")}");
        }
        else
        {
            System.Console.WriteLine("Faltan Datos...");
        }
    }

}


class Alumno : Persona
{
    public string[] ListaAsignaturas { get; set; }
    public string Aula { get; set; }

    public override bool ValidarInformacion()
    {
        return true;
    }
}


class Director : Profesor
{
    public override void MostrarInformacion()
    {
        System.Console.WriteLine($"El nombre del Director es {Nombre} {Apellidos} y tiene {Edad} años.");
    }
}