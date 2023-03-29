namespace Tuplas;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Tupla ===");
        Tuple<string, string> tupla = new Tuple<string, string>("Rubén1", "Rubio");
        Console.WriteLine($"Usuario: {tupla.Item1} {tupla.Item2}");


        Console.WriteLine("=== Desde un Methodo ===");
        // Llamamos al método y almacenamos la tupla en la variable tuplaDesdeMetodo
        var tuplaDesdeMetodo = ObtenerPersona();
        // Escribimos por consola los datos
        Console.WriteLine($"Usuario: {tuplaDesdeMetodo.Item1} {tuplaDesdeMetodo.Item2}");

        Console.WriteLine("=== Tuplas basadas en la estructura ValueTuple ===");
        // Si lo hacemos en la declaración
        (string nombre, string apellido) tupla3 = ("Rubén3", "Rubio");
        Console.WriteLine($"Usuario: {tupla3.nombre} {tupla3.apellido}");

        // Si lo hacemos en la asignación
        var tupla4 = (nombre: "Rubén4", apellido: "Rubio");
        Console.WriteLine($"Usuario: {tupla4.nombre} {tupla4.apellido}");

        System.Console.WriteLine("=== Comparación de tuplas ===");
        (string nombre, string apellido) tupla5 = ("Rubén", "Rubio");
        (string nombre, string apellido) tupla6 = ("Felipe", "Reyes");

        if (tupla5 == tupla6)
            Console.WriteLine("Las tuplas son iguales");
        else
            Console.WriteLine("Las tuplas son distintas");

    }


    public static Tuple<string, string> ObtenerPersona()
    {
        // Creamos una tupla con dos elementos
        Tuple<string, string> tupla = new Tuple<string, string>("Rubén2", "Rubio");

        // Devolvemos la tupla
        return tupla;
    }


}
