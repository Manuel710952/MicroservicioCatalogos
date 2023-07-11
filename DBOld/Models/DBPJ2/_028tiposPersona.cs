using System;
using System.Collections.Generic;

namespace DBOld.Models.DBPJ2;

public partial class _028tiposPersona
{
    public int _028tipoPersonaId { get; set; }

    public string _028nombre { get; set; } = null!;

    public int? _028tipoSujetoIdMajat { get; set; }

    public bool _028activo { get; set; }
}
