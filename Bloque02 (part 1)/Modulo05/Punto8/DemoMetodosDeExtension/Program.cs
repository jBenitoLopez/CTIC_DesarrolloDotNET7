using System.Text;
namespace DemoMetodosDeExtension;
class Program
{
    static void Main(string[] args)
    {
        string texto = "quiero la primera letra de cada palabra en mayúscula.";

        System.Console.WriteLine(texto.Capitalizar());
        System.Console.WriteLine("hola mundo de la programacion.".ConvertirAMayuscula());


        System.Console.WriteLine("===== con Objeto =====");
        Alumno alumno = new();
        alumno.Nombre = "Pepito";
        alumno.Apellidos = "Grillo Duro";
        alumno.FechaNacimiento = new DateTime(2000, 4, 15);
        alumno.MostrarInformacion();

        System.Console.WriteLine(alumno.MostrarPrimerApellido());
    }
}

public static class AlumnoExtension
{
    public static string MostrarPrimerApellido(this Alumno alumno)
    {
        string output = "";
        try
        {
            string[] apellidos = alumno.Apellidos.Split(" ");
            output = $"El primer apellido es {apellidos[0]}";
        }
        catch
        {

        }
        return output;

    }
}

public static class StringExtension
{
    public static string Capitalizar(this string texto)
    {
        string[] palabras = texto.Split(" ");
        for (int i = 0; i < palabras.Length; i++)
        {
            if (palabras[i].Length > 1)
            {
                palabras[i] = char.ToUpper(palabras[i][0]) + palabras[i].Substring(1);
                continue;
            }

            palabras[i] = palabras[i];

        }

        return string.Join(" ", palabras);
    }


    public static string ConvertirAMayuscula(this string cadena)
    {
        string[] palabras = cadena.Split(" ");

        StringBuilder sb = new StringBuilder();

        foreach (var palabra in palabras)
        {
            sb.Append($"{palabra.Substring(0, 1).ToUpper()}{palabra.Substring(1).ToLower()} ");
        }

        return sb.ToString();
    }
}