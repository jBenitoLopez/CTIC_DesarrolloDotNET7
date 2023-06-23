using System;
using System.Collections.Generic;

namespace DEMO_DatabaseFirst.Entidades;

public partial class Pai
{
    public string PaisId { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Provincium> Provincia { get; set; } = new List<Provincium>();
}
