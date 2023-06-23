using System;
using System.Collections.Generic;

namespace DEMO_EntityF.Entidades
{
    public partial class Persona
    {
        public Persona()
        {
            Direccion = new HashSet<Direccion>();
            DireccionEmail = new HashSet<DireccionEmail>();
            PedidoVenta = new HashSet<PedidoVenta>();
            TarjetaCredito = new HashSet<TarjetaCredito>();
            Telefono = new HashSet<Telefono>();
        }

        public string EstadoCivil { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string Puesto { get; set; }
        public int PersonaId { get; set; }
        public string Apellidos { get; set; }
        public string Discriminator { get; set; }
        public string InformacionAdicional { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }

        public virtual Comercial Comercial { get; set; }
        public virtual ICollection<Direccion> Direccion { get; set; }
        public virtual ICollection<DireccionEmail> DireccionEmail { get; set; }
        public virtual ICollection<PedidoVenta> PedidoVenta { get; set; }
        public virtual ICollection<TarjetaCredito> TarjetaCredito { get; set; }
        public virtual ICollection<Telefono> Telefono { get; set; }
    }
}
