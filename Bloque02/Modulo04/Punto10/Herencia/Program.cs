namespace Herencia;
class Program
{
    static void Main(string[] args)
    {
        Persona persona = new();
        persona.Nombre = "Pepito";
        persona.Apellidos = "Grillo";
        persona.MostrarNombre();

        Alumno alumno = new("Michael","Schwab", "Aula 2");
        alumno.MostrarNombre();
        System.Console.WriteLine($"Tiene la Aula: {alumno.Aula}");
        Profesor profesor = new();

        Director director = new();
        director.Despacho = "Planta Alta";
    }
}

class Persona
{
    public string Nombre { get; set; }
    public string Apellidos { get; set; }

    public Persona() { }
    public Persona(string nombre, string apellidos)
    {
        Nombre = nombre;
        Apellidos = apellidos;
    }
    public void MostrarNombre()
    {
        System.Console.WriteLine($"El nombre es {Nombre} {Apellidos}");
    }

    public override string ToString()
    {
        return $@"== Properties ==
        Nombre: {Nombre}
        Apellidos: {Apellidos}
        ";
    }
}

class Alumno : Persona
{
    public Alumno(string nombre, string apellidos, string aula) : base(nombre, apellidos)
    {
        Aula = aula;
    }

    public string[] ListAsignaturas { get; set; }
    public string Aula { get; set; }
    public int edad { get; set; }
}

class Profesor : Persona
{
    public string Asignatura { get; set; }
    public string JefeEstudios { get; set; }
}

class Director : Profesor
{
    public string Despacho { get; set; }
}