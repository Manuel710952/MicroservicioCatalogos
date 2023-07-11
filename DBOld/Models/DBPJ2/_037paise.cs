using System;
using System.Collections.Generic;

namespace DBOld.Models.DBPJ2;

public partial class _037paise
{
    public int _037paisId { get; set; }

    public string _037nombre { get; set; } = null!;

    public string? _037codigo { get; set; }

    public bool _037activo { get; set; }

    public string? _037gentilicioMasculino { get; set; }

    public string? _037gentilicioFemenino { get; set; }

    public virtual ICollection<_011entidadesFederativa> _011entidadesFederativas { get; set; } = new List<_011entidadesFederativa>();
}
