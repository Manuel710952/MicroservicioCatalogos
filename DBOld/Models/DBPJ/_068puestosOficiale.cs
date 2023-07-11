using System;
using System.Collections.Generic;

namespace DBOld.Models.DBPJ;

public partial class _068puestosOficiale
{
    public int _068puestoOficialId { get; set; }

    public string _068nombre { get; set; } = null!;

    public string? _068clave { get; set; }

    public int? _060tipoCategoriaPuestoId { get; set; }

    public bool _068activo { get; set; }

    public virtual ICollection<_045puesto> _045puestos { get; set; } = new List<_045puesto>();

    public virtual _060tiposCategoriasPuesto? _060tipoCategoriaPuesto { get; set; }
}
