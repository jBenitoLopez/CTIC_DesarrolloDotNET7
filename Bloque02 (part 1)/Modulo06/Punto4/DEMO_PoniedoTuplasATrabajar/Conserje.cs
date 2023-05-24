using System;

namespace DEMO_PoniedoTuplasATrabajar
{
    public class Conserje : Persona, IContribuyente<string>, IFuncionario
    {
        public string Referencia { get; set; }
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