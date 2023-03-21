namespace Interfaces;
public class Profesor : Persona, IFuncionario, IContribuyente
{
    public string Asignatura { get; set; }
    public bool JefeEstudios { get; set; }

    public IContribuyente this[string index] => throw new NotImplementedException();

    public string this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    // Declaración de los indizadores
    IFuncionario IFuncionario.this[string index] => throw new NotImplementedException();
    string IFuncionario.this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


    public sealed override void MostrarNombre()
    {
        Console.WriteLine("El nombre es " + Nombre + " " + Apellidos);
    }

    public string CotejarDocumentos()
    {
        throw new NotImplementedException();
    }

}
