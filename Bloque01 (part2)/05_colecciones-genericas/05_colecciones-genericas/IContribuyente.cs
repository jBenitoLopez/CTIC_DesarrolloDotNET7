using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_colecciones_genericas
{
    interface IContribuyente<T>
        where T : struct
    {
        T Referencia { get; set; }
        string Nombre { get; set; }
        string Apellidos { get; set; }

        void PagarImpuestos();
    }
}
