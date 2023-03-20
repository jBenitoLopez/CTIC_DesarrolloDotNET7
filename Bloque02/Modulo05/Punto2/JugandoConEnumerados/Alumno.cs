using System;

namespace JugandoConEnumerados;
public class Alumno : Persona
{
    public string[] ListaAsignaturas { get; set; }
    public string Aula { get; set; }

    public override void MostrarInformacion()
    {
        Console.WriteLine("El nombre es " + Nombre + " " + Apellidos);
    }
}
