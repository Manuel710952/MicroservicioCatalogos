using System;
using System.Collections.Generic;

namespace DBOld.Models.DBPJ;

public partial class _017tiposDomicilio
{
    public int _017tipoDomicilioId { get; set; }

    public string _017nombre { get; set; } = null!;

    public bool _017activo { get; set; }

    public virtual ICollection<_016domicilio> _016domicilios { get; set; } = new List<_016domicilio>();
}
