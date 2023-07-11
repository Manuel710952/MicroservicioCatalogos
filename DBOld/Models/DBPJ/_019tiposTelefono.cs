using System;
using System.Collections.Generic;

namespace DBOld.Models.DBPJ;

public partial class _019tiposTelefono
{
    public int _019tipoTelefonoId { get; set; }

    public string _019nombre { get; set; } = null!;

    public bool _019activo { get; set; }

    public virtual ICollection<_018telefono> _018telefonos { get; set; } = new List<_018telefono>();
}
