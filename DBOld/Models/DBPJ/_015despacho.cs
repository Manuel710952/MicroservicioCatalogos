using System;
using System.Collections.Generic;

namespace DBOld.Models.DBPJ;

public partial class _015despacho
{
    public int _015despachoId { get; set; }

    public string? _015nombre { get; set; }

    public bool? _015activo { get; set; }

    public int? _014abogadoIdDbcuentas { get; set; }

    public int? _021tipoDespachoId { get; set; }

    public int? _022dependenciaPublicaId { get; set; }

    public virtual ICollection<_016domicilio> _016domicilios { get; set; } = new List<_016domicilio>();

    public virtual _021tiposDespacho? _021tipoDespacho { get; set; }

    public virtual _022dependenciasPublica? _022dependenciaPublica { get; set; }
}
