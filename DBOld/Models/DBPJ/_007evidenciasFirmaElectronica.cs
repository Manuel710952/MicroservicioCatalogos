using System;
using System.Collections.Generic;

namespace DBOld.Models.DBPJ;

public partial class _007evidenciasFirmaElectronica
{
    public int _007evidenciaFirmaElectronicaId { get; set; }

    public int? _007usuarioQueFirma001Dbcuentas { get; set; }

    public DateTime _0007fechaCreado { get; set; }

    public string _007rutaCarpetaEvidencias { get; set; } = null!;
}
