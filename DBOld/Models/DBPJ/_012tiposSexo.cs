using System;
using System.Collections.Generic;

namespace DBOld.Models.DBPJ;

public partial class _012tiposSexo
{
    public int _012tipoSexoId { get; set; }

    public string _012nombre { get; set; } = null!;

    public string _012abreviatura { get; set; } = null!;

    public bool _012activo { get; set; }
}
