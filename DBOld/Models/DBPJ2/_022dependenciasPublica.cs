using System;
using System.Collections.Generic;

namespace DBOld.Models.DBPJ2;

public partial class _022dependenciasPublica
{
    public int _022dependenciaPublicaId { get; set; }

    public string _022nombre { get; set; } = null!;

    public bool _022activo { get; set; }

    public virtual ICollection<_015despacho> _015despachos { get; set; } = new List<_015despacho>();
}
