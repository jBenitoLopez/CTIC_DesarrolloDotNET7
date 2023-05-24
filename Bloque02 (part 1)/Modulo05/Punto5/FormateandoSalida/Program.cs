namespace FormateandoSalida;
class Program
{
    static void Main(string[] args)
    {
        int vbleInt = 100;
        Console.WriteLine(vbleInt.ToString("00000"));   // 00100
        DateTime vbleFecha = new DateTime(1990, 1, 25);
        Console.WriteLine(vbleFecha.ToString("dd-MM-yyyy"));    // 25-01-1990
        double vbleDec = 8.25;
        Console.WriteLine(vbleDec.ToString("n3"));  // 8.250
        Console.WriteLine(vbleDec.ToString("p"));   // 8.25 %

        System.Console.WriteLine("--- string.Format ---");
        Alumno alumno = new Alumno();
        alumno.Nombre = "Rubén";
        alumno.Apellidos = "Rubio";
        alumno.FechaNacimiento = new DateTime(1973, 12, 24);

        string texto = string.Format("Me llamo {0} {1}, y nací el {2:D}", alumno.Nombre, alumno.Apellidos, alumno.FechaNacimiento);
        Console.WriteLine(texto);

        System.Console.WriteLine($"--- Interpolación de cadenas ---");
        string texto2 = $"Me llamo {alumno.Nombre} {alumno.Apellidos}, y nací el {alumno.FechaNacimiento:d}";
        Console.WriteLine(texto2);

        System.Console.WriteLine($"--- Uso de expresiones ---");
        string texto3 = $"Me llamo {alumno.Nombre} {alumno.Apellidos}, y {((DateTime.Today.Subtract(alumno.FechaNacimiento).Days / 365.25) > 18 ? "soy" : "no soy")} mayor de edad";
        Console.WriteLine(texto3);

        System.Console.WriteLine($"--- soporte multilínea, carácter @ ---");
        string texto4 = $@"Me llamo {alumno.Nombre}
            {alumno.Apellidos},
y {((DateTime.Today.Subtract(alumno.FechaNacimiento).Days / 365.25) > 18 ? "soy" : "no soy")} mayor de
edad";
        Console.WriteLine(texto4);


        Console.WriteLine($"Me llamo {{Rubén}}"); // Me llamo {Rubén}

        //a partir de la versión 10 de C# 
        const string Curso = "Desarrollo con C#";
        const string Centro = "CampusMVP";
        const string Texto = $"Aprender {Curso} en {Centro}";

        //A partir de la versión 11 del lenguaje C# (.NET 7)
        // string cadenaInterpolada = $"Mostrando fecha corta de ejecución {DateTime
        // .Now
        // .ToShortDateString()}";
        //     Console.WriteLine(cadenaInterpolada);
        // }
    }
