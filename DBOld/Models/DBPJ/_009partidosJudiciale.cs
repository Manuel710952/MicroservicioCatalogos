using System;
using System.Collections.Generic;

namespace DBOld.Models.DBPJ;

public partial class _009partidosJudiciale
{
    public int _009partidoJudicialId { get; set; }

    public string _009nombre { get; set; } = null!;

    public bool _009activo { get; set; }

    public virtual ICollection<_001area> _001areas { get; set; } = new List<_001area>();

    public virtual ICollection<_010municipio> _010municipios { get; set; } = new List<_010municipio>();

    public virtual ICollection<_020sala> _020salas { get; set; } = new List<_020sala>();
}
