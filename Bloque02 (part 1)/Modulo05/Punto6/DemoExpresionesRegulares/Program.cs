using System.Text.RegularExpressions;

namespace DemoExpresionesRegulares;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- REPLACE ---");
        string texto = "El perro de San Roque no está en Roqueta de Mar";
        string resReplace = Regex.Replace(texto, @"R\w{2,4}", "cambio");
        Console.WriteLine($"Before: {texto}");
        Console.WriteLine($"After : {resReplace}");

        Console.WriteLine("--- Regex.Success ---");
        Match resBusqueda = Regex.Match(texto, @"R\w{2,4}");

        int i = 1;
        while (resBusqueda.Success)
        {
            Console.WriteLine($"Match {i++}: {resBusqueda.Value}");
            resBusqueda = resBusqueda.NextMatch();
        }

        Console.WriteLine("--- Regex.IsMatch ---");
        if (Regex.IsMatch(texto, @"R\w{2,4}"))
        {
            System.Console.WriteLine($"Regex have a Match");
        }

        Console.WriteLine("--- Regex.Split ---");
        String[] resSplit = Regex.Split(texto, @"R\w{2,4}");
        foreach (var item in resSplit)
        {
            System.Console.WriteLine(item.Trim());
        }

        Console.WriteLine("--- Validar telefonos con Prefijo Inernacional ---");
        string telefonos = "+34(981)123456\n+34(981)23456\n+34(415)34567\n+34(81)4567890\n+34(91)5678901\n+34(986)6789012";
        string rex = @"^((\+34\(9\d{2}\)\d{6})|(\+34\(9\d\)\d{7}))$";

        System.Console.WriteLine("-- IsMatch --");
        var resTelefonos = Regex.Split(telefonos, "\n");
        foreach (var item in resTelefonos)
        {
            if (Regex.IsMatch(item.Trim(), rex))
            {
                System.Console.WriteLine($"Telefono Valido: {item}");
            }
            else
            {
                System.Console.WriteLine($"Telefono NO Valido: {item}");
            }
        }

        System.Console.WriteLine("-- NextMatch --");
        Match resTelefonosMatch = Regex.Match(telefonos, rex, RegexOptions.Multiline);
        while (resTelefonosMatch.Success)
        {
            System.Console.WriteLine($"Telefono Valido: {resTelefonosMatch.Value}");
            resTelefonosMatch = resTelefonosMatch.NextMatch();
        }

    }
}