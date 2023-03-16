namespace AccesibilidadAmbito;
class Program
{
    static void Main(string[] args)
    {
        Persona persona = new();
        persona.Nombre = "Pepito";
        persona.Apellidos = "Grillo";
        persona.MostrarNombre();

        Animal animal = new();
        animal.MostrarDatos();
        animal.SegundoMetodo();
        animal.EstablecerSpecie("gato");
    }
}



class Persona
{
    public string Nombre { get; set; }
    public string Apellidos { get; set; }

    public void MostrarNombre()
    {
        System.Console.WriteLine($"El nombre es {Nombre} {Apellidos}");
    }

    public override string ToString()
    {
        return $@"== Properties ==
        Nombre: {Nombre}
        Apellidos: {Apellidos}
        ";
    }
}


public class Animal
{
    protected string subEspecie = "Vairable nivel Clase";
    public string Nombre { get; set; }
    public string Especie { get; set; }
    public void MostrarDatos()
    {
        System.Console.WriteLine($"El nombre es {Nombre} y la especie es {Especie}");
        System.Console.WriteLine(subEspecie);
    }

    public void SegundoMetodo()
    {
        string subEspecie = "Vairable nivel Methodo";
        System.Console.WriteLine(this.subEspecie);
        System.Console.WriteLine(subEspecie);
    }

    public void EstablecerSpecie(string nuevaEspecie)
    {
        string nuevoNombreEspecie = DefiniEspecieInt();

        string DefiniEspecieInt()
        {
            if (nuevaEspecie.ToLower() == "perro") return "Dog";
            if (nuevaEspecie.ToLower() == "gato") return "Cat";
            return "Desconocido";
        }

        System.Console.WriteLine($"La nueva especie de {nuevaEspecie} es {nuevoNombreEspecie}");
    }

    private string DefiniEspecie(string nuevaEspecie)
    {
        if (nuevaEspecie.ToLower() == "perro")
        {
            return "Dog";
        }
        if (nuevaEspecie.ToLower() == "gato")
        {
            return "Cat";
        }

        return "Desconocido";
    }
}
