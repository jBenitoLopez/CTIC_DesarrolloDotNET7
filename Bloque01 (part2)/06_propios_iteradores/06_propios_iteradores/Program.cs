using _06_propios_iteradores;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("DEMO: Creando nuestras propias colecciones: iteradores\r\n");


        var matriz = new Conserje[5]
        {
    new Conserje(){Nombre="Conserje 1"},
    new Conserje(){Nombre="Conserje 2"},
    new Conserje(){Nombre="Conserje 3"},
    new Conserje(){Nombre="Conserje 4"},
    new Conserje(){Nombre="Conserje 5"},
        };

        ColeccionConserje lista = new ColeccionConserje(matriz);

        foreach (var conserje in lista)
        {
            Console.WriteLine($"Conserje => {conserje.Nombre}");
        }

        Console.WriteLine($"Recorrido desde un método");
        foreach (var elemento in Iterador())
        {
            Console.WriteLine($"elemento: {elemento}");
        }

    }


    private static IEnumerable<string> Iterador()
    {
        for (var i = 0; i < 10; i++)
        {
           yield return $"Pasada {i}";
        }
    }
}