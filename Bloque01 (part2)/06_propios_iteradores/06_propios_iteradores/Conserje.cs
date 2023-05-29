using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _06_propios_iteradores
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
