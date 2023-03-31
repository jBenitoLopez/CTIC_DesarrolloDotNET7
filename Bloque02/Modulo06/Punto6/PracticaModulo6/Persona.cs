
namespace PracticaModulo6;
public class Persona
{

    public string Nombre { set; get; }
    public string Apellidos { set; get; }
    public Persona() { }
    public Persona(string Nombre, string Apellidos)
    {
        this.Nombre = Nombre;
        this.Apellidos = Apellidos;
    }

}