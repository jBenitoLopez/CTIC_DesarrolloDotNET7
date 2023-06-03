using usando_expresiones_lambda;

public class Program
{
    private static void Main(string[] args)
    {
        //MethodoClase();
        //MethodosAnonimoClase();
        lamda1();

    }



    #region Methodos Anonimo

    private static void MethodoClase()
    {
        // Methodos Anonimo
        Alumno alumno = new Alumno()
        {
            Nombre = "Rubén",
            Apellidos = "Rubio"
        };

        alumno.DatosCambiados += new DatosCambiadosEventHandler(DatosCambiados);

        alumno.Nombre = "Pepito";
        alumno.Apellidos = "Grillo";
    }
    private static void MethodosAnonimoClase()
    {
        // Methodos Anonimo
        Alumno alumno = new Alumno()
        {
            Nombre = "Rubén",
            Apellidos = "Rubio"
        };
        alumno.DatosCambiados += (Prop, Anterior, Nuevo) 
            => Console.WriteLine($"Propiedad: {Prop} - Anterior {Anterior} - Nuevo: {Nuevo}");

        alumno.Nombre = "Pepito";
        alumno.Apellidos = "Grillo";
    }
    private static void DatosCambiados(string NombreProp, string ValorAnterior, string ValorNuevo)
    {
        Console.WriteLine($"Propiedad: {NombreProp} - Anterior {ValorAnterior} - Nuevo: {ValorNuevo}");
    }

    #endregion Methodos Anonimo

    #region Expresiones Lambda
    private static void lamda1()
    {
        //var consulta = from alumno in ObtenerAlumnos()
        //               where alumno.Apellidos.StartsWith("G") || alumno.Apellidos.StartsWith("H")
        //               select alumno;

        // Ejecucion Diferida
        var consulta1 = ObtenerAlumnos()
            .Where(alumno => alumno.Apellidos.StartsWith("G") || alumno.Apellidos.StartsWith("H"));

        // Ejecucion Imediata
        var consulta2 = ObtenerAlumnos()
            .Where(alumno => alumno.Apellidos.StartsWith("G") || alumno.Apellidos
            .StartsWith("H"))
            .ToList();

        var datosOriginales = ObtenerAlumnos();

        // Ejecucion Diferida
        var consulta3 = datosOriginales
            .Where(alumno => alumno.Apellidos.StartsWith("G") || alumno.Apellidos.StartsWith("H"))
            .OrderBy(a => a.Nombre)
            .ThenBy(a => a.Apellidos);

        // Ejecucion Imediata
        var consulta4 = datosOriginales
            .Where(alumno => alumno.Apellidos
            .StartsWith("G") || alumno.Apellidos.StartsWith("H"))
            .Select(alumno => $"{alumno.Nombre} {alumno.Apellidos}")
            .ToList();



        // Ejecucion Diferida
        var consulta5 = datosOriginales
            .Where(alumno => alumno.Apellidos.StartsWith("G") || alumno.Apellidos.StartsWith("H"))
            .Skip(1)  // omitir el primero
            .Take(2); // solo devuelve 2 si los hay

        // Ejecucion Diferida
        var count1 = datosOriginales.Count();
        Console.WriteLine($"\nla variable `datosOriginales` tiene : {count1} Alumnos");

        datosOriginales.Add(new Alumno() { Nombre = "Pepito", Apellidos = "Grillo", TipoPersona = TipoPersona.Alumno, Aula = "Prog. I" });
        datosOriginales.Add(new Alumno() { Nombre = "Manolo", Apellidos = "Hescobar", TipoPersona = TipoPersona.Alumno, Aula = "Cálculo" });

        datosOriginales.Add(new Alumno() { Nombre = "Roberto", Apellidos = "Garcia", TipoPersona = TipoPersona.Alumno, Aula = "Prog. I" });
        datosOriginales.Add(new Alumno() { Nombre = "Pedro", Apellidos = "Barbeito", TipoPersona = TipoPersona.Alumno, Aula = "Cálculo" });

        var count2 = datosOriginales.Count();
        Console.WriteLine($"\nla variable `datosOriginales` tiene ahora: {count2} Alumnos");

        var consulta6 = from profesor in ObtenerProfesores()
                        join alumno in ObtenerAlumnos() on profesor.Asignatura equals alumno.Aula
                        select new { Profesor = profesor, Alumno = alumno };


        var consulta7 = ObtenerProfesores()
            .Join(
                  ObtenerAlumnos()
                , profesor => profesor.Asignatura
                , alumno => alumno.Aula
                , (profesor, alumno) => new { Profesor = profesor, Alumno = alumno }
            );

        var consulta8 = ObtenerProfesores()
            .Join(
                  ObtenerAlumnos()
                , profesor => profesor.Asignatura
                , alumno => alumno.Aula
                , (profesor, alumno) => new { Profesor = profesor, Alumno = alumno }
            ).GroupBy(item => item.Profesor);

        Console.WriteLine($"\n===== CONSULTA 1 - Ejecucion Diferida =====");
        foreach (var alumno in consulta1)
        {
            Console.WriteLine($"Alumno Nombre: {alumno.Nombre} {alumno.Apellidos}");
        }

        Console.WriteLine($"\n===== CONSULTA 2 - Ejecucion Imediata =====");
        foreach (var alumno in consulta2)
        {
            Console.WriteLine($"Alumno Nombre: {alumno.Nombre} {alumno.Apellidos}");
        }

        Console.WriteLine($"\n===== CONSULTA 3 - Ejecucion Diferida,OrderBy,ThenBy =====");
        foreach (var alumno in consulta3)
        {
            Console.WriteLine($"Alumno Nombre: {alumno.Nombre} {alumno.Apellidos}");
        }

        Console.WriteLine($"\n===== CONSULTA 4 - Ejecucion Imediata =====");
        foreach (var alumno in consulta4)
        {
            Console.WriteLine($"Alumno Nombre: {alumno}");
        }

        Console.WriteLine($"\n===== CONSULTA 5 - skip & take =====");
        foreach (var alumno in consulta5)
        {
            Console.WriteLine($"Alumno Nombre: {alumno.Nombre} {alumno.Apellidos}");
        }

        Console.WriteLine($"\n===== CONSULTA 6 - Join con LinkQ =====");
        foreach (var row in consulta6)
        {
            Console.WriteLine($"Alumno Nombre: {row.Alumno.Nombre} {row.Alumno.Apellidos}");
            Console.WriteLine($"Profesor: {row.Profesor.Nombre} {row.Profesor.Apellidos}");
            Console.WriteLine($"---------------------------------------------------------");
        }

        Console.WriteLine($"\n===== CONSULTA 7 - Join con expresiones lambda =====");
        foreach (var row in consulta7)
        {
            Console.WriteLine($"Alumno Nombre: {row.Alumno.Nombre} {row.Alumno.Apellidos}");
            Console.WriteLine($"Profesor: {row.Profesor.Nombre} {row.Profesor.Apellidos}");
            Console.WriteLine($"---------------------------------------------------------");
        }

        Console.WriteLine($"\n===== CONSULTA 8 - Join + groupBy =====");
        foreach (var collection in consulta8)
        {
            Console.WriteLine($"Asignatura: {collection.Key.Asignatura}, Profesor: {collection.Key.Nombre} {collection.Key.Apellidos}, Total Alumnos: {collection.Count()}");

            foreach (var row in collection)
            {
                Console.WriteLine($"  Alumno Nombre: {row.Alumno.Nombre} {row.Alumno.Apellidos}");
            }   
            Console.WriteLine($"---------------------------------------------------------");
        }
    }

    #endregion Expresiones Lambda

    #region Data3
    #endregion Data3

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
                new Profesor() { Nombre = "Fermín", Apellidos = "Cacho", TipoPersona = TipoPersona.Profesor, Asignatura = "Cálculo" },
                new Profesor() { Nombre = "Paco", Apellidos = "López", TipoPersona = TipoPersona.Profesor, Asignatura = "Prog. I" },
                new Profesor() { Nombre = "Martín", Apellidos = "Losantos", TipoPersona = TipoPersona.Profesor, Asignatura = "Algebra" }
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