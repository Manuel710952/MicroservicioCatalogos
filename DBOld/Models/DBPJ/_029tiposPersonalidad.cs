using System;
using System.Collections.Generic;

namespace DBOld.Models.DBPJ;

public partial class _029tiposPersonalidad
{
    public int _029tipoPersonalidadId { get; set; }

    public string _029nombre { get; set; } = null!;

    public int? _029tipoPersonalidadIdMajat { get; set; }

    public int? _029tipoPersonalidadId53equitas { get; set; }

    public bool _029activo { get; set; }

    public virtual ICollection<_002materia> _002materia { get; set; } = new List<_002materia>();
}
