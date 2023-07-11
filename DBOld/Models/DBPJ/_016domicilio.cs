using System;
using System.Collections.Generic;

namespace DBOld.Models.DBPJ;

public partial class _016domicilio
{
    public int _016domicilioId { get; set; }

    public string? _016calle { get; set; }

    public string? _016codigoPostal { get; set; }

    public string? _016numeroExterno { get; set; }

    public string? _016numeroInterno { get; set; }

    public string _016fraccColonia { get; set; } = null!;

    public int _010municipioId { get; set; }

    public int _011entidadFederativaId { get; set; }

    public int? _017tipoDomicilioId { get; set; }

    public int? _015despachoId { get; set; }

    public virtual _015despacho? _015despacho { get; set; }

    public virtual _017tiposDomicilio? _017tipoDomicilio { get; set; }

    public virtual ICollection<_018telefono> _018telefonos { get; set; } = new List<_018telefono>();
}
