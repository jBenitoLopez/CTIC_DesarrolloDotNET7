using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usando_miembros_cuerpo_expresion
{
    interface IFuncionario
    {
        string Nombre { get; set; }
        string Apellidos { get; set; }

        void CotejarDocumentos();
    }
}
