using System;
using System.Collections.Generic;

namespace DBOld.Models.DBPJ2;

public partial class _031sistema
{
    public int _031sistemaId { get; set; }

    public string _031nombre { get; set; } = null!;

    public string _031abreviatura { get; set; } = null!;

    public string _031descripcion { get; set; } = null!;

    public int _032tipoSistemaId { get; set; }

    public int? _025baseDeDatosId { get; set; }

    public string? _031rutaDeAcceso { get; set; }

    public bool? _031activo { get; set; }

    public bool _031puedeModificarseSusPermisos { get; set; }

    public virtual _025basesDeDato? _025baseDeDatos { get; set; }

    public virtual _032tiposSistema _032tipoSistema { get; set; } = null!;

    public virtual ICollection<_063areasSistema> _063areasSistemas { get; set; } = new List<_063areasSistema>();
}
