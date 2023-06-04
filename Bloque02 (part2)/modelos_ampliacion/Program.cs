using modelos_ampliacion;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("09 - Coincidencia de modelos: ampliación\r\n");


        Console.WriteLine("\n===== Switch =====");
        SwitchNormal();
        SwitchExpresion();

        Persona persona = new Persona()
        {
            Nombre = "Rubén",
            Apellidos = "Rubio",
            TipoPersona = TipoPersona.Profesor
        };
        Console.WriteLine($"ObtenerTipoPersona: Valor con switch de expresión Method: {ObtenerTipoPersona(persona)}");


        Console.WriteLine("\n===== Tuplas =====");
        // Para realizar la llamada
        Profesor profesor = new Profesor()
        {
            Nombre = "Rubén",
            Apellidos = "Rubio",
            TipoPersona = TipoPersona.Profesor,
            Asignatura = "Cálculo"
        };

        Console.WriteLine($"ObtenerTipoPersonaTupla(Profesor) - Valor con switch y tupla: {ObtenerTipoPersonaTupla(profesor)}");
        Console.WriteLine($"ObtenerTipoPersonaTuplaMethod(TipoPersona, Asignatura) - Valor con switch y tupla: {ObtenerTipoPersonaTuplaMethod(profesor.TipoPersona, profesor.Asignatura)}");

        Console.WriteLine("\n===== Empleo posicional =====");
        Console.WriteLine($"ObtenerTipoPersonaEmpleoPosicional(Persona): el tipo de persona es {ObtenerTipoPersonaEmpleoPosicional(persona)}");

        Console.WriteLine("\n===== Patrón simple =====");
        Console.WriteLine($"TipoPersonaPatronSimple(Persona): el tipo de persona es {TipoPersonaPatronSimple(persona)}");
        var alumno1 = new Alumno();
        Console.WriteLine(TipoPersonaPatronSimple(alumno1));
        var conserje1 = new Conserje();
        Console.WriteLine(TipoPersonaPatronSimple(conserje1));
        var profesor1 = new Profesor();
        Console.WriteLine(TipoPersonaPatronSimple(profesor1));
        var persona1 = new Persona();
        Console.WriteLine(TipoPersonaPatronSimple(persona1));


        Console.WriteLine("\n===== Patrón relacional =====");
        Console.WriteLine($"TipoPersonaPatronRelacional(Persona): el tipo de persona es {TipoPersonaPatronRelacional(persona)}");

        Console.WriteLine("\n===== Patrón lógico =====");
        Console.WriteLine($"TipoPersonaPatronLogico(nota): el tipo de persona es {TipoPersonaPatronLogico(5)}");
        // Tal como hacíamos hasta ahora
        if (!(alumno1 is Alumno))
        {
            // Código a ejecutar si no se trata de un objeto de tipo Alumno
        }

        // Con el patrón lógico
        if (alumno1 is not Alumno)
        {
            // Código a ejecutar si no se trata de un objeto de tipo Alumno
        }

        Console.WriteLine("\n===== Patrón de lista =====");
        int[] array1 = { 1, 4, 6, 7 };
        int[] array2 = { 1, 3, 9 };
        int[] array3 = { 1, 6, 7 };

        Console.WriteLine("Resultado array1 - [1, 3, 9]: {0}", array1 is [1, 3, 9]);
        Console.WriteLine("Resultado array1 - [1, 6, 7]: {0}", array1 is [1, 6, 7]);
        Console.WriteLine("Resultado array1 - [1, 4, 7]: {0}", array1 is [1, 4, 7]);
        Console.WriteLine("Resultado array2 - [1, 3, 9]: {0}", array2 is [1, 3, 9]);
        Console.WriteLine("Resultado array2 - [1, 6, 7]: {0}", array2 is [1, 6, 7]);
        Console.WriteLine("Resultado array2 - [1, 4, 7]: {0}", array2 is [1, 4, 7]);
        Console.WriteLine("Resultado array3 - [1, 3, 9]: {0}", array3 is [1, 3, 9]);
        Console.WriteLine("Resultado array3 - [1, 6, 7]: {0}", array3 is [1, 6, 7]);
        Console.WriteLine("Resultado array3 - [1, 4, 7]: {0}", array3 is [1, 4, 7]);

        Console.WriteLine("----------------------- ObtenerTipoArray -------------------------------");

        int[] array11 = { 1, 4, 6, 9, 10 };
        int[] array12 = { 1, 3, 9 };
        int[] array13 = { 1, 6, 7, 8, 12 };
        int[] array14 = { 1, 6, 7, 8 };
        int[] array15 = { 1, 3, 4, 6, 14 };

        Console.WriteLine("Resultado array1: {0}", ObtenerTipoArray(array11));
        Console.WriteLine("Resultado array2: {0}", ObtenerTipoArray(array12));
        Console.WriteLine("Resultado array3: {0}", ObtenerTipoArray(array13));
        Console.WriteLine("Resultado array4: {0}", ObtenerTipoArray(array14));
        Console.WriteLine("Resultado array5: {0}", ObtenerTipoArray(array15));

        Console.WriteLine("\n===== Unión y anidación de patrones =====");
        var alumno21 = new Alumno() { Nombre = "Pepito", Apellidos = "Grillo", TipoPersona = TipoPersona.Alumno, Aula = "Algebra", Nota = 7, FechaNacimiento = new DateTime(1973, 3, 23) };
        Console.WriteLine($"Tipo persona: {alumno21.TipoPersona}, Edad: {alumno21.Edad}, Nota: {alumno21.Nota}");
        var resultado = ObtenerTipoPersonaUnionAnidacion(alumno21);
        Console.WriteLine($"resultado: {resultado}");

    }
    #region Unión y anidación de patrones
    private static string ObtenerTipoPersonaUnionAnidacion(Persona persona) =>
       persona switch
       {
           { TipoPersona: TipoPersona.Alumno } => "Tipo alumno",
           { TipoPersona: TipoPersona.Conserje } => "Tipo conserje",
           { TipoPersona: TipoPersona.Rector } => "Tipo rector",
           { TipoPersona: TipoPersona.Secretario } => "Tipo secretario",
           { TipoPersona: TipoPersona.Vigilante } => "Tipo vigilante",
           Profesor p => p.Edad switch
           {
               >= 18 and < 25 => "Profesor novato",
               >= 25 and <= 45 => "Profesor experimentado",
               > 45 => "Profesor eminencia",
               _ => "No puede ser un profesor"
           },
           Alumno al when al.ListaAsignaturas.Length > 4 => al.Nombre + "" + al.ListaAsignaturas.Length.ToString(),
           Alumno al => al.Nota switch
           {
               < 5 => "suspenso",
               >= 5 and < 6 => "suficiente",
               >= 6 and < 7 => "bien",
               >= 7 and < 9 => "notable",
               >= 9 => "sobresaliente"
           },
           _ => "Desconocido"
       };

    #endregion Unión y anidación de patrones

    #region Patrón de lista
    static string ObtenerTipoArray(int[] array) =>
        array switch
        {
            // - 3 o más elementos
            // - primero un 1
            // - el penúltimo 9
            // - cualquier cantidad de elementos en medio
            // - capturamos el elemento final
            [1, .., 9, var valorFinal] => $"Array tipo 1 (final: {valorFinal})",

            // - 3 o más elementos
            // - primero un 1
            // - el penúltimo 7
            // - un número indeterminado de elementos
            // - capturamos el elemento final
            [1, .., 7, var valorFinal] => $"Array tipo 2 (final: {valorFinal})",

            // - 3 o más elementos
            // - primero un 1
            // - a continuación es un elemento opcional
            // - seguido de un 4
            // - un número indeterminado de elementos
            // - capturamos el elemento final
            [1, _, 4, .., var valorFinal] => $"Array tipo 3 (final: {valorFinal})",

            // - 4 o más elementos
            // - el primero un 1
            // - el segundo mayor o igual a 4
            // - a continuación un número indeterminado de elementos
            // - el penúltimo uno inferior a 10
            // - capturamos el elemento final
            [1, >= 4, .., < 10, var valorFinal] => $"Array tipo 4 (final: {valorFinal})",

            // - cualquier otro array
            _ => "Tipo desconocido"
        };


    #endregion Patrón de lista

    #region Patrón lógico
    private static string TipoPersonaPatronLogico(decimal nota) =>
        nota switch
        {
            < 5 => "suspenso",
            >= 5 and < 6 => "suficiente",
            >= 6 and < 7 => "bien",
            >= 7 and < 9 => "notable",
            >= 9 => "sobresaliente"
        };
    #endregion Patrón lógico

    #region Patrón relacional
    private static string TipoPersonaPatronRelacional(Persona persona) =>
    persona switch
    {
        Alumno al when al.Nota >= 9 => "sobresaliente",
        Alumno al when al.Nota >= 7 => "notable",
        Alumno al when al.Nota >= 6 => "bien",
        Alumno al when al.Nota >= 5 => "suficiente",
        _ => "suspenso"
    };
    #endregion Patrón relacional

    #region Patrón simple
    private static string TipoPersonaPatronSimple(Persona persona) =>
        persona switch
        {
            Alumno => "alumno",
            Profesor => "profesor",
            Conserje => "conserje",
            _ => "persona"
        };

    #endregion Patrón simple

    #region Empleo posicional
    private static string ObtenerTipoPersonaEmpleoPosicional(Persona persona) =>
    persona switch
    {
        (TipoPersona.Profesor, "Cálculo") => "Profesor de cálculo",
        (TipoPersona.Profesor, "Álgebra") => "Profesor de álgebra",
        (TipoPersona.Alumno, "Cálculo") => "Alumno de cálculo",
        (TipoPersona.Alumno, "Álgebra") => "Alumno de álgebra",
        (TipoPersona.Rector, _) => "Es el rector",
        (_, _) => "Indiferente"
    };
    #endregion Empleo posicional

    #region tupla
    private static string ObtenerTipoPersonaTupla(Profesor profesor)
    {
        string respuesta = (profesor.TipoPersona, profesor.Asignatura) switch
        {
            (TipoPersona.Profesor, "Cálculo") => "Profesor de cálculo",
            (TipoPersona.Profesor, "Álgebra") => "Profesor de álgebra",
            (TipoPersona.Alumno, "Cálculo") => "Alumno de cálculo",
            (TipoPersona.Alumno, "Álgebra") => "Alumno de álgebra",
            (TipoPersona.Rector, _) => "Es el rector",
            (_, _) => "Indiferente"
        };
        return respuesta;
    }
    private static string ObtenerTipoPersonaTuplaMethod(TipoPersona tipoPersona, string asignatura) =>
    (tipoPersona, asignatura) switch
    {
        (TipoPersona.Profesor, "Cálculo") => "Profesor de cálculo",
        (TipoPersona.Profesor, "Álgebra") => "Profesor de álgebra",
        (TipoPersona.Alumno, "Cálculo") => "Alumno de cálculo",
        (TipoPersona.Alumno, "Álgebra") => "Alumno de álgebra",
        (TipoPersona.Rector, _) => "Es el rector",
        (_, _) => "Indiferente"
    };
    #endregion tupla

    #region switch
    private static void SwitchNormal()
    {
        string respuesta = "";

        Persona persona = new Persona()
        {
            Nombre = "Rubén",
            Apellidos = "Rubio",
            TipoPersona = TipoPersona.Profesor
        };

        switch (persona.TipoPersona)
        {
            case TipoPersona.Alumno:
                respuesta = "Tipo alumno";
                break;
            case TipoPersona.Conserje:
                respuesta = "Tipo conserje";
                break;
            case TipoPersona.Profesor:
                respuesta = "Tipo profesor";
                break;
            case TipoPersona.Rector:
                respuesta = "Tipo rector";
                break;
            case TipoPersona.Secretario:
                respuesta = "Tipo secretario";
                break;
            case TipoPersona.Vigilante:
                respuesta = "Tipo vigilante";
                break;
            default:
                respuesta = "Desconocido";
                break;
        }
        Console.WriteLine($"SwitchNormal: Valor con switch normal: {respuesta}");
    }
    private static void SwitchExpresion()
    {
        Persona persona = new Persona()
        {
            Nombre = "Rubén",
            Apellidos = "Rubio",
            TipoPersona = TipoPersona.Profesor
        };

        string respuesta = persona.TipoPersona switch
        {
            TipoPersona.Alumno => "Tipo alumno",
            TipoPersona.Conserje => "Tipo conserje",
            TipoPersona.Profesor => "Tipo profesor",
            TipoPersona.Rector => "Tipo rector",
            TipoPersona.Secretario => "Tipo secretario",
            TipoPersona.Vigilante => "Tipo vigilante",
            _ => "Desconocido"
        };
        Console.WriteLine($"SwitchLambda: Valor con switch de expresión: {respuesta}");
    }
    private static string ObtenerTipoPersona(Persona persona) =>
    persona.TipoPersona switch
    {
        TipoPersona.Alumno => "Tipo alumno",
        TipoPersona.Conserje => "Tipo conserje",
        TipoPersona.Profesor => "Tipo profesor",
        TipoPersona.Rector => "Tipo rector",
        TipoPersona.Secretario => "Tipo secretario",
        TipoPersona.Vigilante => "Tipo vigilante",
        _ => "Desconocido"
    };
    private static string ObtenerTipoPersonaRefactor(Persona persona) =>
    persona switch
    {
        { TipoPersona: TipoPersona.Alumno } => "Tipo alumno",
        { TipoPersona: TipoPersona.Conserje } => "Tipo conserje",
        { TipoPersona: TipoPersona.Profesor } => "Tipo profesor",
        { TipoPersona: TipoPersona.Rector } => "Tipo rector",
        { TipoPersona: TipoPersona.Secretario } => "Tipo secretario",
        { TipoPersona: TipoPersona.Vigilante } => "Tipo vigilante",
        _ => "Desconocido"
    };
    #endregion switch

    #region Data
    static List<Alumno> ObtenerAlumnos()
    {
        List<Alumno> listaAlumnos = new List<Alumno>()
        {
                new Alumno() { Nombre = "Fernando", Apellidos = "Gómez", TipoPersona = TipoPersona.Alumno, Aula = "Cálculo", Nota = 5, FechaNacimiento=new DateTime(2000, 1, 18)},
                new Alumno() { Nombre = "Esther", Apellidos = "García", TipoPersona = TipoPersona.Alumno, Aula = "Prog. I" , Nota = 3, FechaNacimiento=new DateTime(1973, 4, 15)},
                new Alumno() { Nombre = "José", Apellidos = "Traba", TipoPersona = TipoPersona.Alumno, Aula = "Cálculo" , Nota = 9, FechaNacimiento=new DateTime(1977, 1, 16)},
                new Alumno() { Nombre = "Luis", Apellidos = "Hernández", TipoPersona = TipoPersona.Alumno, Aula = "Prog. I" , Nota = 10, FechaNacimiento=new DateTime(2021, 7, 3)},
                new Alumno() { Nombre = "Raúl", Apellidos = "Esteso", TipoPersona = TipoPersona.Alumno, Aula = "Algebra" , Nota = 7, FechaNacimiento=new DateTime(1953, 3, 23)}
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