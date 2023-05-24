namespace InterfacesMundoReal;
public class Alumno : Persona, IContribuyente
{
    public string[] ListaAsignaturas { get; set; }
    public string Aula { get; set; }

    public override void MostrarNombre()
    {
        Console.WriteLine("El nombre es " + Nombre + " " + Apellidos);
    }

    public void PagarImpuestos()
    {
        System.Console.WriteLine("Impuestos pagados");
    }
}
