namespace InterfazIDisposable;
class Program
{
    static void Main(string[] args)
    {

        // Creamos un objeto Persona
        Persona persona = null;
        System.Console.WriteLine("=== try...catch");
        try
        {
            // Inicializamos el objeto y lo utilizamos
            persona = new Persona();
            persona.OtroMetodo();
        }
        // Controlamos cualquier excepción que pueda producirse
        catch (Exception)
        {
            // Realizamos las acciones necesarias para controlarla
        }
        // En cualquier caso entra en el bloque finally
        finally
        {
            // Si el objeto sigue existiendo, llamamos a Dispose
            if (persona != null) persona.Dispose();


        }

        System.Console.WriteLine("=== Using ===");
        // Creamos un objeto Persona y lo instanciamos con ayuda del using
        using (Persona persona2 = new Persona())
        {
            // Y utilizamos el objeto creado
            persona2.OtroMetodo();
        }
        // No es necesario llamar a Dispose puesto que se encarga el using


        System.Console.WriteLine("=== Using sin llaves ===");
        // Creamos un objeto Persona y lo instanciamos con ayuda del using
        using Persona persona3 = new Persona();

        // Y utilizamos el objeto creado
        persona3.OtroMetodo();

        // No es necesario llamar a Dispose puesto que se encarga el using de finalizarlo
    }
}

