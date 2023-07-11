using System;
using System.Collections.Generic;

namespace DBOld.Models.DBPJ2;

public partial class _067usuariosFirmaElectronicaMultiple
{
    public long _067usuarioId { get; set; }

    public long _066multifirmaId { get; set; }

    public string _067nombre { get; set; } = null!;

    public DateTime? _067fechaEnQueFirmo { get; set; }

    public int? _067areaDeUsarioId { get; set; }

    public string? _067rutaCertificadoPem { get; set; }

    public string? _067rutaLlavePrivadaPem { get; set; }

    public long _067usuarioId001dbcuentas { get; set; }

    public virtual _066solicitudFirmaElectronicaMultiple _066multifirma { get; set; } = null!;
}
