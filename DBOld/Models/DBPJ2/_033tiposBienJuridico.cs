using System;
using System.Collections.Generic;

namespace DBOld.Models.DBPJ2;

public partial class _033tiposBienJuridico
{
    public int _033tipoBienJuridicoId { get; set; }

    public string _033nombre { get; set; } = null!;

    public string? _033codigo { get; set; }

    public bool? _033activo { get; set; }

    public virtual ICollection<_008delito> _008delitos { get; set; } = new List<_008delito>();
}
