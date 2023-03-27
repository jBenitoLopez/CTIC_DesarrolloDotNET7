namespace CoincidenciaDeModelos;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Uso en el if ===");
        Persona persona = new("Pepito", "Grillo", new DateTime(2000, 6, 19));
        Profesor profesor = new();
        profesor.Nombre = "Andres";
        profesor.Apellidos = "Galileo";



        System.Console.WriteLine("=== Instrucción switch ===");
        MostrarPorConsola4(profesor);

    }

    private static void MostrarPorConsola1(object objeto)
    {
        if (objeto is Profesor)
        {
            Profesor profesor = objeto as Profesor;
            Console.WriteLine("Profesor: " + profesor.Nombre + " " + profesor.Apellidos);
        }
        else if (objeto is Alumno)
        {
            Alumno alumno = objeto as Alumno;
            Console.WriteLine("Alumno: " + alumno.Nombre + " " + alumno.Apellidos);
        }
        else
            Console.WriteLine("Función ejecutada");
    }

    private static void MostrarPorConsola2(object objeto)
    {
        if (objeto is Profesor profesor)
            Console.WriteLine("Profesor: " + profesor.Nombre + " " + profesor.Apellidos);
        else if (objeto is Alumno alumno)
            Console.WriteLine("Alumno: " + alumno.Nombre + " " + alumno.Apellidos);
        else
            Console.WriteLine("Función ejecutada");
    }

    private static void MostrarPorConsola3(object objeto)
    {
        switch (objeto)
        {
            case Profesor profesor:
                Console.WriteLine("Profesor: " + profesor.Nombre + " " + profesor.Apellidos);
                break;
            case Alumno alumno:
                Console.WriteLine("Alumno: " + alumno.Nombre + " " + alumno.Apellidos);
                break;
            case Conserje conserje:
                Console.WriteLine("Conserje: " + conserje.Nombre + " " + conserje.Apellidos);
                break;
            default:
                Console.WriteLine("Función ejecutada");
                break;
        }


    }

    private static void MostrarPorConsola4(object objeto)
    {
        switch (objeto)
        {
            case Profesor profesor when profesor.Nombre.StartsWith("A"):
                Console.WriteLine("Profesor que empieza por A: " + profesor.Nombre + " " + profesor.Apellidos);
                break;
            case Alumno alumno when alumno.Nombre.StartsWith("A"):
                Console.WriteLine("Alumno que empieza por A: " + alumno.Nombre + " " + alumno.Apellidos);
                break;
            case Profesor profesor:
                Console.WriteLine("Profesor: " + profesor.Nombre + " " + profesor.Apellidos);
                break;
            case Alumno alumno:
                Console.WriteLine("Alumno: " + alumno.Nombre + " " + alumno.Apellidos);
                break;
            case Conserje conserje:
                Console.WriteLine("Conserje: " + conserje.Nombre + " " + conserje.Apellidos);
                break;
            default:
                Console.WriteLine("Función ejecutada");
                break;
        }

    }
}