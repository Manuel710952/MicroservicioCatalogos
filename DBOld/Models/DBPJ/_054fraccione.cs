using System;
using System.Collections.Generic;

namespace DBOld.Models.DBPJ;

public partial class _054fraccione
{
    public int _054fraccionId { get; set; }

    public string _054numero { get; set; } = null!;

    public string _054numeroRomano { get; set; } = null!;

    public string _054nombre { get; set; } = null!;

    public string? _054descripcion { get; set; }

    public int _053articuloId { get; set; }

    public bool? _054activo { get; set; }

    public virtual _053articulo _053articulo { get; set; } = null!;

    public virtual ICollection<_055inciso> _055incisos { get; set; } = new List<_055inciso>();
}
