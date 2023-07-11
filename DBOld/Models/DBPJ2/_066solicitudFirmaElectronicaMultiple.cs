using System;
using System.Collections.Generic;

namespace DBOld.Models.DBPJ2;

public partial class _066solicitudFirmaElectronicaMultiple
{
    public long _066multifirmaId { get; set; }

    public string? _066descripcion { get; set; }

    public DateTime _066fechaDeSolicitud { get; set; }

    public string _066rutaDeDocumentoAfirmar { get; set; } = null!;

    public string? _066rutaDeDocumentoFirmado { get; set; }

    public int? _066areaId { get; set; }

    public virtual ICollection<_067usuariosFirmaElectronicaMultiple> _067usuariosFirmaElectronicaMultiples { get; set; } = new List<_067usuariosFirmaElectronicaMultiple>();
}
