namespace PracticaModulo6;

public class Profesor : Persona, IComparar
{

    public Profesor(string nombre, string apellidos) : base(nombre, apellidos)
    {

    }

    public string Asignatura { get; set; } = "";
    public bool EsJefeDeEstudios { get; set; }

}
