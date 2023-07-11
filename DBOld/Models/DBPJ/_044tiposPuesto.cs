using System;
using System.Collections.Generic;

namespace DBOld.Models.DBPJ;

public partial class _044tiposPuesto
{
    public int _044tipoPuestoId { get; set; }

    public string _044nombre { get; set; } = null!;

    public bool _044activo { get; set; }

    public DateTime _044fechaRegistro { get; set; }

    public int _044usuarioQuienRegistro001dbcuentas { get; set; }

    public virtual ICollection<_045puesto> _045puestos { get; set; } = new List<_045puesto>();
}
