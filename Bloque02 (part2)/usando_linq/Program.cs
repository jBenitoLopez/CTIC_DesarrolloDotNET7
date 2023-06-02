using usando_linq;

internal class Program
{
    private static void Main(string[] args)
    {
        //ConsultarPersonas01();
        //ConsultarPersonas02();
        //ConsultarPersonas03();
        //ConsultarPersonas04();

        //ConsultarUnionAlumnoProfesor01();

        //CombinacionInterna();
        //CombinacionExternaIzquierda();
        //CombinacionAgrupada();
        //CombinacionAgrupada02();
        CombinacionAgrupada03();
    }

    #region Join
    private static void CombinacionInterna()
    {
        // Left Join
        var consulta = from profesor in ObtenerProfesores()
                       join alumno in ObtenerAlumnos() on profesor.Asignatura equals alumno.Aula
                       select new { Alumno = alumno, Profesor = profesor };

        foreach (var item in consulta)
        {
            Console.WriteLine($"Profesor: {item.Profesor.Nombre} {item.Profesor.Apellidos}. Alumno: {item.Alumno.Nombre} {item.Alumno.Apellidos}");
        }
    }
    private static void CombinacionExternaIzquierda()
    {
        // Right Join
        var consulta = from profesor in ObtenerProfesores()
                       join alumno in ObtenerAlumnos() on profesor.Asignatura equals alumno.Aula into profAlumno
                       from alumnoCombinado in profAlumno.DefaultIfEmpty(new Alumno() { Nombre = "", Apellidos = "" })
                       select new { Alumno = alumnoCombinado, Profesor = profesor };

        foreach (var item in consulta)
        {
            Console.WriteLine($"Profesor: {item.Profesor.Nombre} {item.Profesor.Apellidos}. Alumno: {item.Alumno.Nombre} {item.Alumno.Apellidos}");
        }
    }
    private static void CombinacionAgrupada()
    {
        var consulta = from combinada in
                           from profesor in ObtenerProfesores()
                           join alumno in ObtenerAlumnos() on profesor.Asignatura equals alumno.Aula
                           select new { Alumno = alumno, Profesor = profesor }
                       where combinada.Profesor.Nombre == combinada.Alumno.Nombre
                       select combinada;

        foreach (var item in consulta)
        {
            Console.WriteLine($"Profesor: {item.Profesor.Nombre} {item.Profesor.Apellidos}. Alumno: {item.Alumno.Nombre} {item.Alumno.Apellidos}");
        }
    }
    private static void CombinacionAgrupada02()
    {
        var consulta = from profesor in ObtenerProfesores()
                       join alumno in ObtenerAlumnos() on profesor.Asignatura equals alumno.Aula into profeAlumnos
                       select new { Profesor = profesor, Alumno = profeAlumnos };


        foreach (var item in consulta)
        {
            Console.WriteLine($"Profesor: {item.Profesor.Nombre} {item.Profesor.Apellidos}.");

            foreach (var alumno in item.Alumno)
            {
                Console.WriteLine($"  Alumno: {alumno.Nombre} {alumno.Apellidos}");
            }
        }
    }
    private static void CombinacionAgrupada03()
    {
        // Groupe By
        var consulta = from alumno in ObtenerAlumnos()
                       group alumno by alumno.Aula;

        foreach (var item in consulta)
        {
            Console.WriteLine($"Key: {item.Key}. Total Elements: {item.Count()}");
            foreach (var alumno in item)
            {
                Console.WriteLine($"  Alumno: {alumno.Nombre} {alumno.Apellidos}");
            } 
        }

       
    }
    #endregion Join

    #region Consultar2from
    private static void ConsultarUnionAlumnoProfesor01()
    {
        var consulta = from alumno in ObtenerAlumnos()
                       from profesor in ObtenerProfesores()
                       select new { Alumno = alumno, Profesor = profesor };

        foreach (var item in consulta)
        {
            Console.WriteLine($"Profesor: {item.Profesor.Nombre} {item.Profesor.Apellidos}. Alumno: {item.Alumno.Nombre} {item.Alumno.Apellidos}");
        }
    }
    #endregion Consultar2from

    #region ConsultarPersonas
    private static void ConsultarPersonas01()
    {
        var consultaPersonas = from persona in ObtenerPersonas()
                               select persona;

        foreach (var persona in consultaPersonas)
        {
            Console.WriteLine($"Persona: {persona.Nombre} {persona.Apellidos}");
        }
    }
    private static void ConsultarPersonas02()
    {
        var personas = ObtenerPersonas();

        var consultaPersonas = from persona in personas
                               select persona;

        personas.Add(new Persona() { Nombre = "Pepito", Apellidos = "Grillo", TipoPersona = TipoPersona.Alumno });

        foreach (var persona in consultaPersonas)
        {
            Console.WriteLine($"Persona: {persona.Nombre} {persona.Apellidos}");
        }
    }
    private static void ConsultarPersonas03()
    {
        var personas = ObtenerPersonas();

        IEnumerable<Persona> consultaPersonas = (from persona in personas
                                                 select persona).ToList();

        foreach (var persona in consultaPersonas)
        {
            Console.WriteLine($"Persona: {persona.Nombre} {persona.Apellidos}");
        }
    }
    private static void ConsultarPersonas04()
    {
        var consultaPersonas = from persona in ObtenerPersonas()
                               where persona.Nombre.StartsWith("F") || persona.Nombre.StartsWith("P")
                               orderby persona.Nombre
                               select persona;


        foreach (var persona in consultaPersonas)
        {
            Console.WriteLine($"Persona: {persona.Nombre} {persona.Apellidos}");
        }

    }
    #endregion ConsultarPersonas

    #region Datos
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
                new Persona() { Nombre = "Paco", Apellidos = "López", TipoPersona = TipoPersona.Profesor },
                new Persona() { Nombre = "Esther", Apellidos = "García", TipoPersona = TipoPersona.Alumno },
                new Persona() { Nombre = "José", Apellidos = "Traba", TipoPersona = TipoPersona.Alumno },
                new Persona() { Nombre = "Fermín", Apellidos = "Cacho", TipoPersona = TipoPersona.Profesor },
                new Persona() { Nombre = "Luis", Apellidos = "Hernández", TipoPersona = TipoPersona.Alumno },
                new Persona() { Nombre = "Raúl", Apellidos = "Esteso", TipoPersona = TipoPersona.Alumno }
            };

        return listaPersonas;
    }
    #endregion Datos
}