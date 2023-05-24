namespace TiposGenericos
{
    public class Conserje : Persona, IContribuyente, IFuncionario
    {
        public void PagarImpuestos()
        {
            Console.WriteLine("Pagando impuestos");
        }

        public void CotejarDocumentos()
        {
            Console.WriteLine("Cotejando documentos");
        }

        public override void MostrarNombre()
        {
            Console.WriteLine("El nombre es " + Nombre + " " + Apellidos);
        }
    }
}