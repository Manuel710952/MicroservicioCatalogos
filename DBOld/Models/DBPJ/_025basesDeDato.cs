using System;
using System.Collections.Generic;

namespace DBOld.Models.DBPJ;

public partial class _025basesDeDato
{
    public int _025baseDeDatosId { get; set; }

    public string _025nombre { get; set; } = null!;

    public string _025descripcion { get; set; } = null!;

    public bool? _025activo { get; set; }

    public virtual ICollection<_031sistema> _031sistemas { get; set; } = new List<_031sistema>();
}
