using System;
using System.Collections.Generic;

namespace DEMO_DatabaseFirst.Entidades;

public partial class DireccionEmail
{
    public int DireccionEmailId { get; set; }

    public string? Email { get; set; }

    public int PersonaId { get; set; }

    public virtual Persona Persona { get; set; } = null!;
}
