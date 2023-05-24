using System;

namespace JugandoConEnumerados;
public class Profesor : Persona
{
    public string Asignatura { get; set; }
    public bool JefeEstudios { get; set; }

    public sealed override void MostrarInformacion()
    {
        Console.WriteLine("El nombre es " + Nombre + " " + Apellidos);
    }
}
