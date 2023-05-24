using System.Reflection.Metadata;
namespace ClasesPropiedadesMetodos;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Class --");
        Persona persona1 = new Persona();
        Persona persona2 = new();
        var persona3 = new Persona();

        persona1.Nombre = "Pepito";
        persona1.Apellidos = "Grillo";
        persona1.Edad = 49;
        persona1.MostrarInfo();
        // System.Console.WriteLine(persona1.ToString());
        string nuevosDatos = persona1.CambiarNombre("Pato", "Donald");
        string apellidoRef = "Pipilota";
        int tamano;

        string nuevoApellidos = persona1.CambiarApellidos(ref apellidoRef, out tamano);
        persona1.MostrarInfo();
        System.Console.WriteLine($"- apellidoRef: {apellidoRef}" );
        System.Console.WriteLine($"- tamano: {tamano}" );
        System.Console.WriteLine(nuevosDatos);


    }
}


class Persona
{
    private string nombre;
    private string apellidos;


    public string Nombre
    {
        get
        {
            return nombre;
        }
        set
        {
            nombre = value;
        }
    }

    public string Apellidos
    {
        get => apellidos;
        set => apellidos = value;
    }

    public int Edad { get; set; }

    public string CambiarNombre(string nombre, string apellidos)
    {
        Nombre = nombre;
        Apellidos = apellidos;
        return this.ToString();
    }

    public string CambiarApellidos(ref string apellidos)
    {
        Apellidos = apellidos;
        apellidos = "Apellidos REF";
        return this.ToString();
    }
    public string CambiarApellidos(ref string apellidos, out int tamano)
    {
        Apellidos = apellidos;
        apellidos = "Apellidos REF";
        tamano = apellidos.Length;
        return this.ToString();
    }

    public void MostrarInfo()
    {
        Console.WriteLine(this.ToString());
    }

    public override string ToString()
    {
        return $@"== Properties ==
        Nombre: {Nombre}
        Apellidos: {Apellidos}
        Edad: {Edad}
        ";
    }
}