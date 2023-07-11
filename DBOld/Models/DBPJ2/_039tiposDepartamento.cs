using System;
using System.Collections.Generic;

namespace DBOld.Models.DBPJ2;

public partial class _039tiposDepartamento
{
    public int _039tipoDepartamentoId { get; set; }

    public string _039nombre { get; set; } = null!;

    public bool _039activo { get; set; }

    public virtual ICollection<_040tiposDepartamentosArea> _040tiposDepartamentosAreas { get; set; } = new List<_040tiposDepartamentosArea>();
}
