namespace ConstructoresDestructores;
class Program
{
    static void Main(string[] args)
    {
        Persona persona1 = new();
        persona1.Nombre = "Pepito";
        persona1.Apellidos = "Grillo";
        persona1.MostrarNombre();

        Persona persona2 = new("Pato", "Donald");
        persona2.MostrarNombre();

        Persona persona3 = new("Clark", "Kent", new DateTime(2000, 1, 18));
        persona3.MostrarNombre();
    }
}

class Persona
{
    public string Nombre { get; set; } = "Sin nombre";
    public string Apellidos { get; set; } = "Sin apellidos";

    public DateTime FechaNacimiento { get; set; } = new DateTime(1900, 1, 1);

    public Persona()
    {
    }
    public void MostrarNombre()
    {
        System.Console.WriteLine($"El nombre es {Nombre} {Apellidos} y nacio el {FechaNacimiento}");
    }

    public Persona(string nombre, string apellidos)
    {
        Nombre = nombre;
        Apellidos = apellidos;
    }

    public Persona(string nombre, string apellidos, DateTime fechaNacimento) : this(nombre, apellidos)
    {
        FechaNacimiento = fechaNacimento;
    }

    public override string ToString()
    {
        return $@"== Properties ==
        Nombre: {Nombre}
        Apellidos: {Apellidos}
        Fecha Naciemento: {FechaNacimiento}
        ";
    }

    // Desctructor
    ~Persona()
    {
        System.Console.WriteLine("Objeto Destruido");
    }
}
