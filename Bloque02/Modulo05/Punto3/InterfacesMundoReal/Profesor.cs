namespace InterfacesMundoReal;
public class Profesor : Persona, IFuncionario, IContribuyente
{
    public string Asignatura { get; set; }
    public bool JefeEstudios { get; set; }

    public sealed override void MostrarNombre()
    {
        Console.WriteLine("El nombre es " + Nombre + " " + Apellidos);
    }

    public void CotejarDocumentos()
    {
        System.Console.WriteLine("Cotejar documentos");
    }

    public void PagarImpuestos()
    {
        System.Console.WriteLine("Impuestos Pagados !!!");
    }

}
