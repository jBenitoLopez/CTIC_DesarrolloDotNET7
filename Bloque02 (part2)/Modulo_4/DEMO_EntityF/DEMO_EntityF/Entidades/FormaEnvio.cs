using System;
using System.Collections.Generic;

namespace DEMO_EntityF.Entidades
{
    public partial class FormaEnvio
    {
        public FormaEnvio()
        {
            PedidoVenta = new HashSet<PedidoVenta>();
        }

        public int FormaEnvioId { get; set; }
        public decimal Coste { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<PedidoVenta> PedidoVenta { get; set; }
    }
}
