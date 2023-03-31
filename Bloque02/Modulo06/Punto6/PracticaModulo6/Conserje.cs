namespace PracticaModulo6;
public class Conserje : Persona, IComparar
{

    public Conserje(string nombre, string apellidos) : base(nombre, apellidos)
    {

    }

    public string Referencia { get; set; } = "";
    public void PagarImpuestos()
    {
        Console.WriteLine("Pagando impuestos");
    }

    public void CotejarDocumentos()
    {
        Console.WriteLine("Cotejando documentos");
    }
}

