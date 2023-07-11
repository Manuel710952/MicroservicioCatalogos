using System;
using System.Collections.Generic;

namespace DBOld.Models.DBPJ;

public partial class _046tramite
{
    public int _046tramiteId { get; set; }

    public string _046nombre { get; set; } = null!;

    public int? _042juicioId { get; set; }

    public bool? _046asignacionDirecta5F { get; set; }

    public bool? _046asignacionDirecta6F { get; set; }

    public decimal? _046tipoTramiteEquitasId021equitas { get; set; }

    public short? _046tipoTramiteMajatIdDbmajat { get; set; }

    public bool? _046activo { get; set; }

    public virtual _042juicio? _042juicio { get; set; }
}
