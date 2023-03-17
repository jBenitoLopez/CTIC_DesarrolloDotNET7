namespace ClasesStaticas;
class Program
{
    static void Main(string[] args)
    {
        Persona persona = new("Pepito", "Grillo", new DateTime(1973, 4, 15));
        persona.MostrarInformacion();
        Persona persona1 = new();
        persona.MostrarInformacion();
        Persona persona2 = new();
        persona.MostrarInformacion();
        Persona persona3 = new();
        persona.MostrarInformacion();

        System.Console.WriteLine(Persona.ObtenerTexto());

        System.Console.WriteLine(Funciones.ObtenerTexto());

        System.Console.WriteLine($"Ya existen {Persona.ContadorEstatico} instancias de la clase Persona");
    }
}


public class Persona
{
    #region Propiedades
    private DateTime fechaNacimiento;
    public int Contador { get; set; } = 0;
    public static int ContadorEstatico { get; set; } = 0;

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

    static Persona()
    {
        ContadorEstatico = 1000;
    }

    public Persona()
    {
        Contador++;
        ContadorEstatico++;
        Nombre = "Sin nombre";
        Apellidos = "Sin apellidos";
        this.fechaNacimiento = DateTime.Today;
    }

    public Persona(string nombre, string apellidos) : this()
    {
        Nombre = nombre;
        Apellidos = apellidos;
    }


    public Persona(string nombre, string apellidos, DateTime fechaNacimento) : this(nombre, apellidos)
    {
        this.fechaNacimiento = fechaNacimento;
    }
    #endregion Constructores

    #region StaticsMetodos
    public static string ObtenerTexto()
    {
        return "Texto desde método Estatico...";
    }
    #endregion StaticsMetodos

    #region Metodos

    public virtual void MostrarInformacion()
    {
        System.Console.WriteLine($"El nombre es {Nombre} {Apellidos} y tiene {Edad} años.");
        System.Console.WriteLine($"Contador Clase: {Contador}");
        System.Console.WriteLine($"Contador Statico: {ContadorEstatico}");
    }

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

public static class Funciones
{
    public static string ObtenerTexto()
    {
        return "Texto desde Clase Estatica!!!";
    }
}
