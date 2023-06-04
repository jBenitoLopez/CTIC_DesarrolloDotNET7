using System;

namespace modelos_ampliacion
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

        // Clase Profesor
        public override void Deconstruct(out TipoPersona tipoPersona, out string asignatura)
        {
            tipoPersona = TipoPersona;
            asignatura = Asignatura;
        }
    }
}