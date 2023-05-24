namespace ClasesParciales;
public class Program
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
