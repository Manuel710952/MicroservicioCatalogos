using System;
using System.Collections.Generic;

namespace DBOld.Models.DBPJ;

public partial class _010municipio
{
    public int _010municipioId { get; set; }

    public string _010nombre { get; set; } = null!;

    public string? _010codigo { get; set; }

    public int? _009partidoJudicialId { get; set; }

    public int _011entidadFederativaId { get; set; }

    public bool? _010activo { get; set; }

    public virtual ICollection<_001area> _001areas { get; set; } = new List<_001area>();

    public virtual _009partidosJudiciale? _009partidoJudicial { get; set; }

    public virtual _011entidadesFederativa _011entidadFederativa { get; set; } = null!;
}
