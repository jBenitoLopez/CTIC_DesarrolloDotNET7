using System;
using System.Collections.Generic;

namespace DEMO_EntityF.Entidades
{
    public partial class TarjetaCredito
    {
        public TarjetaCredito()
        {
            PedidoVenta = new HashSet<PedidoVenta>();
        }

        public int TarjetaCreditoId { get; set; }
        public short AnnoExpiracion { get; set; }
        public byte MesExpiracion { get; set; }
        public string Numero { get; set; }
        public int PersonaId { get; set; }
        public string Tipo { get; set; }

        public virtual Persona Persona { get; set; }
        public virtual ICollection<PedidoVenta> PedidoVenta { get; set; }
    }
}
