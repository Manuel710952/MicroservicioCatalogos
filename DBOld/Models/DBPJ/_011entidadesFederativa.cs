using System;
using System.Collections.Generic;

namespace DBOld.Models.DBPJ;

public partial class _011entidadesFederativa
{
    public int _011entidadFederativaId { get; set; }

    public string _011nombre { get; set; } = null!;

    public string? _011codigo { get; set; }

    public int? _037paisId { get; set; }

    public bool? _011activo { get; set; }

    public virtual ICollection<_010municipio> _010municipios { get; set; } = new List<_010municipio>();

    public virtual _037paise? _037pais { get; set; }
}
