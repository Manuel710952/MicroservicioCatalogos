using System;
using System.Collections.Generic;

namespace DBOld.Models.DBPJ;

public partial class _049autoridadesFederale
{
    public int _049autoridadFederalId { get; set; }

    public string _049nombre { get; set; } = null!;

    public bool? _049activo { get; set; }

    public int _050tipoAutoridadFederalId { get; set; }

    public virtual _050tiposAutoridadFederal _050tipoAutoridadFederal { get; set; } = null!;
}
