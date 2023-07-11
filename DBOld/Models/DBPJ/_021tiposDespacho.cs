using System;
using System.Collections.Generic;

namespace DBOld.Models.DBPJ;

public partial class _021tiposDespacho
{
    public int _021tipoDespachoId { get; set; }

    public string? _021nombre { get; set; }

    public bool _021activo { get; set; }

    public virtual ICollection<_015despacho> _015despachos { get; set; } = new List<_015despacho>();
}
