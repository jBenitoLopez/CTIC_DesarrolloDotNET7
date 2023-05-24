using System.Text.RegularExpressions;

namespace ExpresionesRegulares;
class Program
{
    static void Main(string[] args)
    {
        Regex email1rex = new Regex(@"^[\w-\.]{3,}@([\w-]{2,}\.)*[\w-]{2,}\.[\w-]{2,4}$");
        Regex email2rex = new Regex("^[\\w-\\.]{3,}@([\\w-]{2,}\\.)*[\\w-]{2,}\\.[\\w-]{2,4}$");

        System.Console.WriteLine("-- REGEX --");
        string texto;
        texto = "El perro de San Roque no está en Roqueta de Mar";
        System.Console.WriteLine($"Texto: {texto}");
        string pat = @"\bRoque\b";
        bool b;
        // Usando el método estático
        b = Regex.IsMatch(texto, pat);
        Console.WriteLine("Usando un método estático: {0}", b);
        // Usando una instancia
        Regex re = new Regex(pat);
        b = re.IsMatch(texto);
        Console.WriteLine("Usando una instancia: {0}", b);

        System.Console.WriteLine("-- REPLACE --");
        string res = Regex.Replace(texto, pat, "Pedro");
        System.Console.WriteLine($"Texto after Replace: {res}");

        System.Console.WriteLine("-- REPLACE 2 --");
        texto = "El perro de San Roque no está en Roqueta de Mar";
        pat = @"\b\w{2,3}\b"; // Patrón para buscar solo las palabras de 2 ó 3 letras
        Regex re2 = new Regex(pat);
        MatchEvaluator mev2 = new MatchEvaluator(MatchEval); // Indicar el delegado a usar
        string res2 = re2.Replace(texto, mev2); // Reemplazar usando el delegado
        Console.WriteLine("Cadena original: {0}", texto);
        Console.WriteLine("Cadena modificada: {0}", res2);

        System.Console.WriteLine("-- MATCH --");
        pat = @"\w+";
        Match m = Regex.Match(texto, pat);
        while (m.Success)
        {
            Console.WriteLine(m.Value);
            m = m.NextMatch();
        }

        System.Console.WriteLine("-- SPLIT --");
        string[] fragmentos = Regex.Split(texto, "[ro]{2}|e");
        for (int i = 0; i < fragmentos.Length; i++)
        {
            Console.WriteLine("'{0}'", fragmentos[i]);
        }

        System.Console.WriteLine("-- OBTENER CORREOS --");
        string email = "mensaje@contoso.com\n" +
                "micuenta@dominio.com\n" +
                "la.cuenta@novalida\n" +
                "la.cuenta@valida.com";
        Console.WriteLine("Las cuentas de correo son: {0}\n", email);
        Console.WriteLine("Cuentas válidas:");
        Regex re3 = new Regex(@"^(?[\w-\.]{3,})@(?<servidor>([\w-\.]{2,}\.)([\w-]{2,4}))$", RegexOptions.Multiline);
        Match m3 = re3.Match(email);
        while (m3.Success)
        {
            Console.WriteLine("Correo válido: {0}", m3.Value);
            m3 = m3.NextMatch();
        }

    }
    private static string MatchEval(Match m)
    {
        return m.ToString().ToUpper();
    }
}
