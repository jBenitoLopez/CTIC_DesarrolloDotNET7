namespace InstruccionesIterativas;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n----- WHILE -----");
        int contador = 12;
        while (contador > 0)
        {
            contador--;

            if (contador % 2 != 0)
            {
                continue;
            }
            Console.WriteLine(contador);


            if (contador < 5)
            {
                break;
            }
        }

        Console.WriteLine("\n----- DO WHILE -----");
        Console.WriteLine("\n----- Tareas -----");
        string nuevaTarea = String.Empty;
        List<string> tareas = new List<string>();
        do
        {
            nuevaTarea = String.Empty;
            Console.Write("Escribe una nueva tarea: ");
            nuevaTarea = Console.ReadLine() ?? "";

            if (nuevaTarea != String.Empty)
            {
                tareas.Add(nuevaTarea);
            }

        } while (nuevaTarea != String.Empty);

        Console.WriteLine("\n----- Foreach -----");
        Console.WriteLine("\nTareas pendientes de ralizar: ");
        foreach (string tarea in tareas)
        {
            Console.WriteLine($" - {tarea}");
        }

        Console.WriteLine("\n----- For -----");
        string[] nombres = { "Antonio", "María", "Luis" };
        for (int i = 0; i < nombres.Length; i++)
        {
            
            Console.WriteLine($"La posición {i} tiene el valor `{nombres[i]}`");
        }

    }
}
