namespace TiposGenericos;
class Program
{
    static void Main(string[] args)
    {
        Alumno alumno = new Alumno();
        alumno.Nombre = "Rubén";
        alumno.Apellidos = "Rubio";

        // AccionPersona accion = new AccionPersona<Alumno, int>();
        AccionPersona<Alumno, int> accion = new AccionPersona<Alumno, int>();

        accion.Persona = alumno;
    }
}

