namespace CoincidenciaDeModelos;

public class Profesor : Persona
{
    public string Asignatura { get; set; }
    public bool EsJefeDeEstudios { get; set; }

    public override void MostrarInformacion()
    {

        System.Console.WriteLine($"El nombre del profesor es {Nombre} {Apellidos} y tiene {Edad} años.\nAsignatura: {Asignatura}, Es el Jefe de Estudio: {(EsJefeDeEstudios ? "Si" : "No")}");
    }

}
