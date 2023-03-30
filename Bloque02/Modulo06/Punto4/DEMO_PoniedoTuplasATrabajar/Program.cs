namespace DEMO_PoniedoTuplasATrabajar;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("DEMO: Poniendo las tuplas a trabajar");

        Alumno alumno1 = new()
        {
            Nombre = "Pepito",
            Apellidos = "Grillo"
        };

        Alumno alumno2 = new()
        {
            Nombre = "Manolo",
            Apellidos = "Grillo"
        };

        // Tuple
        var comparacion = CompararAlumnos(alumno1, alumno2);
        System.Console.WriteLine($"(Tuple) Resultado CompararAlumnos: {comparacion.Item1}, {comparacion.Item2}");

        // Struct
        var comparacion2 = CompararAlumnos2(alumno1, alumno2);
        System.Console.WriteLine($"(ValueTuple) Resultado CompararAlumnos: {comparacion2.Item1}, {comparacion2.Item2}");


        // Struct - con nombres de variables
        var comparacion3 = CompararAlumnos3(alumno1, alumno2);
        System.Console.WriteLine($"(ValueTuple con var nombre) Resultado CompararAlumnos: {comparacion3.esIgual}, {comparacion3.mensaje}");

        // Struct - con nombres de variables
        var (esIgual, mensaje) = CompararAlumnos3(alumno1, alumno2);
        System.Console.WriteLine($"(ValueTuple deconstruido) Resultado CompararAlumnos: {esIgual}, {mensaje}");
    }

    private static Tuple<bool, string> CompararAlumnos(Alumno alumno1, Alumno alumno2)
    {
        if (alumno1.Nombre == alumno2.Nombre && alumno1.Apellidos == alumno2.Apellidos)
        {
            return new Tuple<bool, string>(true, "Son Iguales!");
        }

        return new Tuple<bool, string>(false, "Son Distintos!");
    }

    private static (bool, string) CompararAlumnos2(Alumno alumno1, Alumno alumno2)
    {
        if (alumno1.Nombre == alumno2.Nombre && alumno1.Apellidos == alumno2.Apellidos)
        {
            return (true, "Son Iguales!");
        }

        return (false, "Son Distintos!");
    }


    private static (bool esIgual, string mensaje) CompararAlumnos3(Alumno alumno1, Alumno alumno2)
    {
        if (alumno1.Nombre == alumno2.Nombre && alumno1.Apellidos == alumno2.Apellidos)
        {
            return (true, "Son Iguales!");
        }

        return (false, "Son Distintos!");
    }
}
