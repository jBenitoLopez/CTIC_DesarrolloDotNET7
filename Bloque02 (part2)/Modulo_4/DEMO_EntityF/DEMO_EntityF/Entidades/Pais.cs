using System;
using System.Collections.Generic;

namespace DEMO_EntityF.Entidades
{
    public partial class Pais
    {
        public Pais()
        {
            Provincia = new HashSet<Provincia>();
        }

        public string PaisId { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Provincia> Provincia { get; set; }
    }
}
