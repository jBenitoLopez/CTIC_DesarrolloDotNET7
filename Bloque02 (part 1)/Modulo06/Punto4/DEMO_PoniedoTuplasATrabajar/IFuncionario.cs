using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_PoniedoTuplasATrabajar
{
    interface IFuncionario
    {
        string Nombre { get; set; }
        string Apellidos { get; set; }

        void CotejarDocumentos();
    }
}
