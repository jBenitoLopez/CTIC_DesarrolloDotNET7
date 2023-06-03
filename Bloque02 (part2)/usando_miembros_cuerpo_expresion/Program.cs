
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    #region Data
    static List<Alumno> ObtenerAlumnos()
    {
        List<Alumno> listaAlumnos = new List<Alumno>()
            {
                new Alumno() { Nombre = "Fernando", Apellidos = "Gómez", TipoPersona = TipoPersona.Alumno, Aula = "Cálculo" },
                new Alumno() { Nombre = "Esther", Apellidos = "García", TipoPersona = TipoPersona.Alumno, Aula = "Prog. I" },
                new Alumno() { Nombre = "José", Apellidos = "Traba", TipoPersona = TipoPersona.Alumno, Aula = "Cálculo" },
                new Alumno() { Nombre = "Luis", Apellidos = "Hernández", TipoPersona = TipoPersona.Alumno, Aula = "Prog. I" },
                new Alumno() { Nombre = "Raúl", Apellidos = "Esteso", TipoPersona = TipoPersona.Alumno, Aula = "Algebra" }
            };

        return listaAlumnos;
    }

    static List<Profesor> ObtenerProfesores()
    {
        List<Profesor> listaProfesores = new List<Profesor>()
            {
                new Profesor() { Nombre = "Fernando", Apellidos = "Cacho", TipoPersona = TipoPersona.Profesor, Asignatura = "Cálculo" },
                new Profesor() { Nombre = "Paco", Apellidos = "López", TipoPersona = TipoPersona.Profesor, Asignatura = "Prog. I" },
                new Profesor() { Nombre = "Martín", Apellidos = "Losantos", TipoPersona = TipoPersona.Profesor, Asignatura = "Algebra" },
                new Profesor() { Nombre = "Rubén", Apellidos = "Rubio", TipoPersona = TipoPersona.Profesor, Asignatura = "Algebra II" }
            };

        return listaProfesores;
    }

    static List<Persona> ObtenerPersonas()
    {
        List<Persona> listaPersonas = new List<Persona>()
            {
                new Persona() { Nombre = "Fernando", Apellidos = "Gómez", TipoPersona = TipoPersona.Alumno },
                new Persona() { Nombre = "Fermín", Apellidos = "Cacho", TipoPersona = TipoPersona.Profesor },
                new Persona() { Nombre = "Esther", Apellidos = "García", TipoPersona = TipoPersona.Alumno },
                new Persona() { Nombre = "José", Apellidos = "Traba", TipoPersona = TipoPersona.Alumno },
                new Persona() { Nombre = "Paco", Apellidos = "López", TipoPersona = TipoPersona.Profesor },
                new Persona() { Nombre = "Luis", Apellidos = "Hernández", TipoPersona = TipoPersona.Alumno },
                new Persona() { Nombre = "Raúl", Apellidos = "Esteso", TipoPersona = TipoPersona.Alumno }
            };

        return listaPersonas;
    }
    #endregion Data
}