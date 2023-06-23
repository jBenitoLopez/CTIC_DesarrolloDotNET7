using System;
using System.Collections.Generic;

namespace DEMO_EntityF.Entidades
{
    public partial class Direccion
    {
        public Direccion()
        {
            PedidoVentaDireccionEnvio = new HashSet<PedidoVenta>();
            PedidoVentaDireccionFacturacion = new HashSet<PedidoVenta>();
        }

        public int DireccionId { get; set; }
        public string? Ciudad { get; set; }
        public int ClienteId { get; set; }
        public string? CodigoPostal { get; set; }
        public string? Linea1 { get; set; }
        public string? Linea2 { get; set; }
        public int ProvinciaId { get; set; }

        public virtual Persona? Cliente { get; set; }
        public virtual Provincia? Provincia { get; set; }
        public virtual ICollection<PedidoVenta> PedidoVentaDireccionEnvio { get; set; }
        public virtual ICollection<PedidoVenta> PedidoVentaDireccionFacturacion { get; set; }
    }
}
