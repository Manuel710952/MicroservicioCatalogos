using System;
using System.Collections.Generic;

namespace DBOld.Models.DBPJ;

public partial class _050tiposAutoridadFederal
{
    public int _050tipoAutoridadFederalId { get; set; }

    public string _050nombre { get; set; } = null!;

    public bool? _050activo { get; set; }

    public virtual ICollection<_049autoridadesFederale> _049autoridadesFederales { get; set; } = new List<_049autoridadesFederale>();
}
