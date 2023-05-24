using System.Text.RegularExpressions;
namespace PracticasPropuestasModulo5_5;
class Program
{
    /*
    Define y prueba con un programa las siguientes expresiones regulares:

    Validar un email. OJO, debes tener en cuenta que los dominios de primer 
    nivel (.com, .es, etc...) tienen varias posibles longitudes y que un email 
    puede contener puntos en el nombre y también más de un punto después de la 
    arroba. 
    En la expresión regular captura los valores del usuario y del dominio de 
    primer nivel por separado, de modo que luego puedas usarlos directamente de 
    manera independiente. 
    
    Por ejemplo, en el correo "usuario.principal@usuarios.empresa.com", además 
    de validar que es un correo correcto deberás capturar por separado el 
    valor "usuario.principal" y "empresa.com" (sin el subdominio o subdominos que tuviese).

    --

    Dada una cadena que contenga etiquetas HTML dentro, extrae todos los valores 
    que estén dentro de etiquetas que van por parejas, pero no el resto. 
    
    Por ejemplo, si la cadena es: 
    "En un lugar de <b>La Mancha</b> de cuyo <a href="http://www.lamancha.es">nombre</a> no quiero acordarme...", 
    debería devolver los valores "La Mancha" y "nombre". 
    
    OJO: si hay más de una etiqueta igual deberás asegurarte de que se extraen todos 
    los elementos y no solo uno con todo lo del medio. 
    
    Por ejemplo, en esta cadena: 
    "En un lugar de <span>La Mancha</span> de cuyo nombre <span>no</span> quiero acordarme...", 
    debería extraer "La Mancha" y "no", 
    pero no 
    "La Mancha</span> de cuyo nombre <span>no" 
    que sería muy típico en estos casos (Pista: deberás asegurarte de usar cuantificadores non-greedy).
    */
    static void Main(string[] args)
    {
        Console.WriteLine("=== Validar Correo ===");
        string email = "usuario.principal@usuarios.empresa.com";
        Regex rexEmail = new Regex(@"^([\w]{3,})[\w\.\-]*@[\w\.\-]*(\.[\w]{2,})$");
        System.Console.WriteLine($"El email `{email}` {(rexEmail.IsMatch(email) ? "es valido." : "no es valido!!!")}");

        //(<[\w =":\/\.]+>[\w ]+<\/[\w]>)*
        Console.WriteLine("=== Validar HTML ===");
        string html = "En un lugar de <b>La Mancha</b> de cuyo <a href=\"http://www.lamancha.es\">nombre</a> no quiero acordarme..., En un lugar de <span>La Mancha</span> de cuyo nombre <span>no</span> quiero acordarme...";
        string pattern = @">([\w ]*)<\/";
        MatchCollection matches = Regex.Matches(html, pattern, RegexOptions.Multiline);

        foreach (Match match in matches)
        {
            GroupCollection groups = match.Groups;
            Console.WriteLine(groups[1]);
        }

    }
}
