namespace Enumraciones;
class Program
{
    // Declaración del enumerado
    enum TipoPersonaLista
    {
        alumno,
        profesor,
        rector,
        secretario,
        conserje,
        vigilante
    }


    enum TipoPersonaClaveValor
    {
        alumno = 1,
        profesor = 3,
        rector = 5,
        secretario = 7,
        conserje = 9,
        vigilante = 11
    }

    // por defecto asigna el tipo Int
    enum TipoPersonaConTipoDatos : byte
    {
        alumno = 1,
        profesor = 3,
        rector = 5,
        secretario = 7,
        conserje = 9,
        vigilante = 11
    }


    // bit a bit
    [Flags()]
    enum TipoPersonaFlags
    {
        ninguno = 0,
        alumno = 1,
        profesor = 2,
        rector = 4,
        secretario = 8,
        conserje = 16,
        vigilante = 32
    }

    static void Main(string[] args)
    {

        // Declaración de una variable que lo usa e inicialización a uno de los valores
        TipoPersonaLista variableTipoLista = TipoPersonaLista.profesor;
        TipoPersonaLista tipo = (TipoPersonaLista)4;
        Console.WriteLine($"\nTipoPersonaLista: {tipo}");

        TipoPersonaLista tipoListaRangoFuera = (TipoPersonaLista)10;
        if (Enum.IsDefined(typeof(TipoPersonaLista), tipoListaRangoFuera) == false)
        {
            tipoListaRangoFuera = TipoPersonaLista.alumno;
        }
        Console.WriteLine($"\ntipoListaRangoFuera: {tipoListaRangoFuera}");

        TipoPersonaFlags variableTipoFlags = TipoPersonaFlags.profesor | TipoPersonaFlags.rector;
        Console.WriteLine($"\nTipoPersonaFlags: {variableTipoFlags}");


        if (variableTipoFlags.HasFlag(TipoPersonaFlags.alumno))
        {
            Console.WriteLine("Persona correcta 1");
        }

        if (variableTipoFlags.HasFlag(TipoPersonaFlags.profesor | TipoPersonaFlags.rector))
        {
            Console.WriteLine("Persona correcta 2");
        }

    }


}

class Persona
{
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public int Tipo { get; set; }
}