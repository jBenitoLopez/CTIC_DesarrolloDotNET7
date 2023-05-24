
namespace Eventos;

// delegate void StringDelegate(string text);
public class Program
{
    static void Main(string[] args)
    {
        Persona persona = new();
        persona.OnChange += DatosCambiados;
        persona.Nombre = "Pepito";
        persona.Apellidos = "Grillo";
        persona.FechaNacimiento = new DateTime(1973, 4, 15);
        persona.MostrarInformacion();
        persona.Nombre = "Jose";


        // StringDelegate stringDelegate = ToUpperCase;
        // stringDelegate("This is lowercase.");
        // stringDelegate("This is another lowercase String");
        // stringDelegate = ToLowerCase;
        // stringDelegate("THIS is UPPERCASE.");
        // stringDelegate("THIS IS ANOTHER UPPERCASE STRING");
    }

    // public static void DatosCambiados(string campo, string valorAnterior, string valorNuevo)
    // {
    //     Console.WriteLine($">>>>> \n  Se cambio el campo `{campo}` \n  del valor anterior `{valorAnterior}` \n  al valor nuevo `{valorNuevo}` \n<<<<<<");
    // }

    // public static void DatosCambiados(object sender, EventArgs args)
    // {
    //     Persona p = (Persona)sender;

    //     System.Console.WriteLine($">> Se modifico el campo `{p.Apellidos}`");
    // }

    public static void DatosCambiados(object sender, DemoEventArgs args)
    {
        Persona p = (Persona)sender;

        Console.WriteLine($">>>>> \n  Se cambio el campo `{args.Campo}` \n  del valor anterior `{args.ValorAnterior}` \n  al valor nuevo `{args.ValorNuevo}` \n<<<<<<");
    }

    // static void ToUpperCase(string text) => Console.WriteLine(text.ToUpper());
    // static void ToLowerCase(string text) => Console.WriteLine(text.ToLower());

}
