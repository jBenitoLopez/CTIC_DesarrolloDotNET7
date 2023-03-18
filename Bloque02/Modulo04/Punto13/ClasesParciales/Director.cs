namespace ClasesParciales;

public class Director : Profesor
{
    public override void MostrarInformacion()
    {
        System.Console.WriteLine($"El nombre del Director es {Nombre} {Apellidos} y tiene {Edad} años.");
    }
}