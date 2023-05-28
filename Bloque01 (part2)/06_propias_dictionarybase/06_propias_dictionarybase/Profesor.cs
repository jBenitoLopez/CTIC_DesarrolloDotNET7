using System;

namespace _06_propias_dictionarybase
{
    public class Profesor : Persona, IContribuyente<int>, IFuncionario
    {
        public int Referencia { get; set; }
        public string Asignatura { get; set; }
        public bool JefeEstudios { get; set; }

        public sealed override void MostrarNombre()
        {
            Console.WriteLine("El nombre es " + Nombre + " " + Apellidos);
        }

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