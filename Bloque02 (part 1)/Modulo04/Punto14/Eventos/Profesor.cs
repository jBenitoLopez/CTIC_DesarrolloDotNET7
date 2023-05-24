namespace Eventos;

public class Profesor : Persona
{
    public string Asignatura { get; set; }
    public bool EsJefeDeEstudios { get; set; }

    private Profesor()
    {

    }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"El nombre del profesor es {Nombre} {Apellidos} y tiene {Edad} años.\nAsignatura: {Asignatura}, Es el Jefe de Estudio: {(EsJefeDeEstudios ? "Si" : "No")}");
    }

}
