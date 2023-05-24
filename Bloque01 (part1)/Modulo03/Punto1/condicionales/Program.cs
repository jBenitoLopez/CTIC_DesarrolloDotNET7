using System.Collections.Generic;

namespace condicionales;
class Program
{
    static void Main(string[] args)
    {
        string pais = "Español";

        Dictionary<string,string> paises = new Dictionary<string,string>();
        paises.Add("Inglés","Hello");
        paises.Add("Francés","Salut");
        paises.Add("Español","Hola");

        System.Console.WriteLine($"En {pais} se dice `{paises[pais]}`");

        System.Console.WriteLine("\n----- SWITCH -----");
        var idioma = "Español";
        switch (idioma)
        {
            case "Inglés":
                Console.WriteLine("Hello");
                break;
            case "Francés":
                Console.WriteLine("Salut");
                break;
            case "Español":
            case "Italiano":
            case "Griego":
                Console.WriteLine("Hola desde el mediterráneo");
                break;
            default:
                Console.WriteLine("Idioma desconocido");
                break;
        }


    }
}
