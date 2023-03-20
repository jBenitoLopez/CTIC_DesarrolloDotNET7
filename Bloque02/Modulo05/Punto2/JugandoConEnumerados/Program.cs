namespace JugandoConEnumerados;
class Program
{
    static void Main(string[] args)
    {
        Persona persona = new Persona("Rubén", "Rubio", new DateTime(1950, 1, 1));
        persona.TipoPersona = TipoPersona.Alumno;
        persona.TipoPersonaBitByBit = TipoPersonaBitByBit.Alumno | TipoPersonaBitByBit.Vigilante;
        if (persona.TipoPersonaBitByBit.HasFlag(TipoPersonaBitByBit.Alumno))
        {
            System.Console.WriteLine("Es un alumno!!!");
        }
        System.Console.WriteLine($"Tipo persona ({persona.TipoPersona}) es {(int)persona.TipoPersona}");
        System.Console.WriteLine($"BitABit {persona.TipoPersonaBitByBit}");
        persona.MostrarInformacion();
    }
}
