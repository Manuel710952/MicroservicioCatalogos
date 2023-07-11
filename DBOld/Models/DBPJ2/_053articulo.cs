using System;
using System.Collections.Generic;

namespace DBOld.Models.DBPJ2;

public partial class _053articulo
{
    public int _053articuloId { get; set; }

    public string _053numero { get; set; } = null!;

    public string _053nombre { get; set; } = null!;

    public string? _053encabezado { get; set; }

    public string? _053pie { get; set; }

    public bool? _053activo { get; set; }

    public virtual ICollection<_054fraccione> _054fracciones { get; set; } = new List<_054fraccione>();

    public virtual ICollection<_008delito> _008delitos { get; set; } = new List<_008delito>();
}
