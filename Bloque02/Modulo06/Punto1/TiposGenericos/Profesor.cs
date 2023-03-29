namespace TiposGenericos
{
    public class Profesor : Persona, IContribuyente, IFuncionario
    {
        public string Asignatura { get; set; }
        public bool JefeEstudios { get; set; }

        //public sealed override void MostrarNombre()
        //{
        //    Console.WriteLine("El nombre es " + Nombre + " " + Apellidos);
        //}

        public void PagarImpuestos()
        {
            Console.WriteLine("Pagando impuestos");
        }

        public void CotejarDocumentos()
        {
            Console.WriteLine("Cotejando documentos");
        }
    }
}