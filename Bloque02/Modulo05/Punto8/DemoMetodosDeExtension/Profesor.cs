namespace DemoMetodosDeExtension;

public class Profesor : Persona
{
    public string Asignatura { get; set; }
    public bool EsJefeDeEstudios { get; set; }

    public override bool ValidarInformacion()
    {
        return true;
    }

    public override void MostrarInformacion()
    {
        if (ValidarInformacion())
        {
            System.Console.WriteLine($"El nombre del profesor es {Nombre} {Apellidos} y tiene {Edad} años.\nAsignatura: {Asignatura}, Es el Jefe de Estudio: {(EsJefeDeEstudios ? "Si" : "No")}");
        }
        else
        {
            System.Console.WriteLine("Faltan Datos...");
        }
    }

}
