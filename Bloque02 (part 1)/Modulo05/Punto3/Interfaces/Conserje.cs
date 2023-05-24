namespace Interfaces;
public class Conserje : Persona
{
    public sealed override void MostrarNombre()
    {
        Console.WriteLine("El nombre es " + Nombre + " " + Apellidos);
    }

}

