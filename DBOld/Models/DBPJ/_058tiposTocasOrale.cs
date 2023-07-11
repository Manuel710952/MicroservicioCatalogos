using System;
using System.Collections.Generic;

namespace DBOld.Models.DBPJ;

public partial class _058tiposTocasOrale
{
    public int _058tipoTocaOralId { get; set; }

    public string _058nombre { get; set; } = null!;

    public bool _058activo { get; set; }

    public virtual ICollection<_001area> _001areas { get; set; } = new List<_001area>();

    public virtual ICollection<_059tiposRecurso> _059tipoRecursos { get; set; } = new List<_059tiposRecurso>();
}
