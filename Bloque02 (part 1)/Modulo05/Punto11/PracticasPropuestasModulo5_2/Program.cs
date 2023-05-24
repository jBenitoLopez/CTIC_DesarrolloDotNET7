namespace PracticasPropuestasModulo5_2;
class Program
{
    /*
    Crea un nuevo proyecto y dentro de éste define una nueva clase llamada Usuario. 
    Ésta nos servirá para representar la información de unos usuarios ficticios de un sistema de informes. 
    Su única propiedad de momento será su nombre (Nombre). 
    Los usuarios pueden ser de varios tipos: 
        Lector si solo puede leer los informes, 
        OperadorInformes si va a poder publicar nuevos informes, 
        GestorUsuarios si va a poder definir, editar y borrar usuarios del sistema de informes, 
        y Administrador si tiene las facultades de los dos anteriores y además puede gestionar otros parámetros de configuración.


    Define una enumeración TipoUsuario para representar todos estos tipos de usuario. 
    ¿Qué valores le debes asignar? 
    ¿Alguna otra consideración importante?

    Ahora define una propiedad Tipo para los usuarios que sea del tipo TipoUsuario que acabas de definir.

    Crea tres usuarios llamados "Manuel", "Antonio" y "María" y que sean respectivamente: lector, lector y operador de informes, 
    y todos los posibles tipos a la vez (los 4 existentes) en el caso de "María".

    Ahora define dos funciones externas a la clase Usuario, 
    llamadas EsGestorDeUsuarios y EsAdministrador que tomen como parámetro un usuario 
    y devuelvan verdadero o falso en función de si el usuario que se le pase es un 
    gestor de usuarios o un administrador respectivamente. 
    Como condición está prohibido utilizar ningún tipo de estructura o condicional dentro de estas funciones, solo operadores. 
    
    Ahora ejecuta y muestra por pantalla el resultado ambas funciones con los tres usuarios para comprobar que funcionan bien.
    */

    static void Main(string[] args)
    {
        Usuario manuel = new Usuario { Nombre = "Manuel" };
        manuel.Tipo = TipoUsuario.Lector;

        Usuario antonio = new Usuario { Nombre = "Antonio" };
        antonio.Tipo = TipoUsuario.Lector | TipoUsuario.OperadorInformes;

        Usuario maria = new Usuario { Nombre = "María" };
        maria.Tipo = TipoUsuario.Lector | TipoUsuario.Administrador;


        Usuario aitor = new Usuario { Nombre = "Aitor" };
        aitor.Tipo = TipoUsuario.GestorUsuarios;

        bool manuelEsGestor = EsGestorDeUsuarios(manuel);
        bool manuelEsAdmin = EsAdministrador(manuel);
        System.Console.WriteLine($"{manuel.Nombre} {(manuelEsGestor ? "es" : "no es")} Gestor de usuarios.");
        System.Console.WriteLine($"{manuel.Nombre} {(manuelEsAdmin ? "es" : "no es")} Administrador de usuarios.");
        System.Console.WriteLine();

        bool antonioEsGestor = EsGestorDeUsuarios(antonio);
        bool antonioEsAdmin = EsAdministrador(antonio);
        System.Console.WriteLine($"{antonio.Nombre} {(antonioEsGestor ? "es" : "no es")} Gestor de usuarios.");
        System.Console.WriteLine($"{antonio.Nombre} {(antonioEsAdmin ? "es" : "no es")} Administrador de usuarios.");
        System.Console.WriteLine();

        bool mariaEsGestor = EsGestorDeUsuarios(maria);
        bool mariaEsAdmin = EsAdministrador(maria);
        System.Console.WriteLine($"{maria.Nombre} {(mariaEsGestor ? "es" : "no es")} Gestor de usuarios.");
        System.Console.WriteLine($"{maria.Nombre} {(mariaEsAdmin ? "es" : "no es")} Administrador de usuarios.");
        System.Console.WriteLine();

        bool aitorEsGestor = EsGestorDeUsuarios(aitor);
        bool aitorEsAdmin = EsAdministrador(aitor);
        System.Console.WriteLine($"{aitor.Nombre} {(aitorEsGestor ? "es" : "no es")} Gestor de usuarios.");
        System.Console.WriteLine($"{aitor.Nombre} {(aitorEsAdmin ? "es" : "no es")} Administrador de usuarios.");
        System.Console.WriteLine();
    }

    private static bool EsAdministrador(Usuario usuario)
    {
        if (usuario.Tipo.HasFlag(TipoUsuario.Administrador)) return true;

        return false;
    }

    private static bool EsGestorDeUsuarios(Usuario usuario)
    {
        if (usuario.Tipo.HasFlag(TipoUsuario.GestorUsuarios)) return true;

        return false;
    }
}
