using System;
using System.Collections.Generic;

namespace DBOld.Models.DBPJ2;

public partial class _065caracteristicasPerspectivaDeGenero
{
    public int _065caracteristicaPerspectivaDeGeneroId { get; set; }

    public string _065nombre { get; set; } = null!;

    public int _064tipoClasificacionPerspectivaDeGeneroId { get; set; }

    public bool _065activo { get; set; }
}
