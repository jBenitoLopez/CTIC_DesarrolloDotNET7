using System;
using System.Collections.Generic;

namespace DEMO_EntityF.Entidades
{
    public partial class Telefono
    {
        public int TelefonoId { get; set; }
        public string? NumeroTelefono { get; set; }
        public int PersonaId { get; set; }

        public virtual Persona? Persona { get; set; }
    }
}
