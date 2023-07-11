using System;
using System.Collections.Generic;

namespace DBOld.Models.DBPJ;

public partial class _043coloresCaratula
{
    public int _043colorCaratulaId { get; set; }

    public string _043nombre { get; set; } = null!;

    public DateTime? _043fechaInicio { get; set; }

    public DateTime? _043fechaTermino { get; set; }

    public string? _043hexadecimal { get; set; }

    public virtual ICollection<_042juicio> _042juicios { get; set; } = new List<_042juicio>();
}
