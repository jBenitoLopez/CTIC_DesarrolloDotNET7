using System;

namespace modelos_ampliacion
{
    public class Conserje : Persona, IContribuyente<int>, IFuncionario
    {
        public int Referencia { get; set; }

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