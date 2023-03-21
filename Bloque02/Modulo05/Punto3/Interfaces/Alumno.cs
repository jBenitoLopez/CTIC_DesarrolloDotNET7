namespace Interfaces;
public class Alumno : Persona, IContribuyente
{
    public string this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public IContribuyente this[string index] => throw new NotImplementedException();

    public string[] ListaAsignaturas { get; set; }
    public string Aula { get; set; }

    public override void MostrarNombre()
    {
        Console.WriteLine("El nombre es " + Nombre + " " + Apellidos);
    }
}
