using System;
using System.Collections.Generic;

namespace DBOld.Models.DBPJ2;

public partial class _013tiposDelito
{
    public int _013tipoDelitoId { get; set; }

    public string _013nombre { get; set; } = null!;

    public string? _013codigo { get; set; }

    public bool _013activo { get; set; }

    public virtual ICollection<_008delito> _008delitos { get; set; } = new List<_008delito>();
}
