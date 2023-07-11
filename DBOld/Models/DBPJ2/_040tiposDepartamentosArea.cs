using System;
using System.Collections.Generic;

namespace DBOld.Models.DBPJ2;

public partial class _040tiposDepartamentosArea
{
    public int _040tipoDepartamentoAreaId { get; set; }

    public int _001areaId { get; set; }

    public int? _039tipoDepartamentoId { get; set; }

    public virtual _001area _001area { get; set; } = null!;

    public virtual _039tiposDepartamento? _039tipoDepartamento { get; set; }

    public virtual ICollection<_045puesto> _045puestos { get; set; } = new List<_045puesto>();
}
