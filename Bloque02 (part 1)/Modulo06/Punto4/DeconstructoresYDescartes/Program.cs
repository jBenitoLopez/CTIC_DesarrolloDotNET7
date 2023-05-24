namespace DeconstructoresYDescartes;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Deconstructores y Descartes ===");

        var tuplaDesdeMetodo = ObtenerDatos();
        Console.WriteLine($"Usuario: {tuplaDesdeMetodo.nombre} {tuplaDesdeMetodo.apellido}");

        // Con declaración explícita
        Console.WriteLine("=== Con declaración explícita ===");
        (string nombreExplicito, string apellidoExplicito) = ObtenerDatos();
        Console.WriteLine($"Usuario con declaración explícita: {nombreExplicito} {apellidoExplicito}");

        // Con declaración implícita
        Console.WriteLine("=== Con declaración implícita ===");
        var (nombreImplicito, apellidoImplicito) = ObtenerDatos();
        Console.WriteLine($"Usuario con declaración implícita: {nombreImplicito} {apellidoImplicito}");

        // asignación a variables ya existentes
        Console.WriteLine("=== asignación a variables ya existentes ===");
        string nombre = "";
        string apellido = "";

        (nombre, apellido) = ObtenerDatos();
        Console.WriteLine($"Usuario con asignación: {nombre} {apellido}");

        // mezclar ambas opciones
        Console.WriteLine("=== mezclar ambas opciones ===");
        string nombre2 = "";

        (nombre2, string apellido2) = ObtenerDatos();
        Console.WriteLine($"Usuario con asignación y declaración: {nombre2} {apellido2}");

        // Deconstrucción en nuestras clases
        Console.WriteLine("=== Deconstrucción en nuestras clases ===");
        Alumno alumno3 = new Alumno()
        {
            Nombre = "Rubén",
            Apellidos = "Rubio"
        };

        var (nombre3, apellido3) = alumno3;
        Console.WriteLine($"Alumno deconstruído: {nombre3} {apellido3}");

        // Descartes
        Console.WriteLine("=== Descartes ===");
        var (nombreImplicito2, _) = ObtenerDatos();
        Console.WriteLine($"Usuario con Descartes, implícita: {nombreImplicito2}");

    }

    public static (string nombre, string apellido) ObtenerDatos()
    {
        return ("Rubén", "Rubio");
    }

}
