using System;
using System.Collections.Generic;

namespace DBOld.Models.DBPJ;

public partial class _059tiposRecurso
{
    public int _059tipoRecursoId { get; set; }

    public string _059nombre { get; set; } = null!;

    public bool _059activo { get; set; }

    public virtual ICollection<_004tiposDocumento> _004tipoDocumentos { get; set; } = new List<_004tiposDocumento>();

    public virtual ICollection<_058tiposTocasOrale> _058tipoTocaOrals { get; set; } = new List<_058tiposTocasOrale>();
}
