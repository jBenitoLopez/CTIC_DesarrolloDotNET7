using System;
using System.Collections.Generic;

namespace DEMO_EntityF.Entidades
{
    public partial class Provincia
    {
        public Provincia()
        {
            Direccion = new HashSet<Direccion>();
        }

        public int ProvinciaId { get; set; }
        public string CodigoProvincia { get; set; }
        public string Nombre { get; set; }
        public string PaisId { get; set; }

        public virtual Pais Pais { get; set; }
        public virtual ICollection<Direccion> Direccion { get; set; }
    }
}
