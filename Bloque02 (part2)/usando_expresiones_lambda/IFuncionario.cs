using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usando_expresiones_lambda
{
    interface IFuncionario
    {
        string Nombre { get; set; }
        string Apellidos { get; set; }

        void CotejarDocumentos();
    }
}
