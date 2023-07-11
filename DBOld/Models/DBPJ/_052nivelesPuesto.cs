using System;
using System.Collections.Generic;

namespace DBOld.Models.DBPJ;

public partial class _052nivelesPuesto
{
    public int _052nivelPuestoId { get; set; }

    public string _052nombre { get; set; } = null!;

    public bool _052activo { get; set; }

    public DateTime _052fechaRegistro { get; set; }

    public int _044usuarioQuienRegistro001dbcuentas { get; set; }

    public virtual ICollection<_045puesto> _045puestos { get; set; } = new List<_045puesto>();
}
