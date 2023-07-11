using System;
using System.Collections.Generic;

namespace DBOld.Models.DBPJ2;

public partial class _004tiposDocumento
{
    public int _004tipoDocumentoId { get; set; }

    public string _004descripcion { get; set; } = null!;

    public int? _004tipoDocumentoIdEquitas { get; set; }

    public int? _004tipoDocumentoIdMajat { get; set; }

    public bool _004documentoPrincipal { get; set; }

    public bool? _004activo { get; set; }

    public virtual ICollection<_003areasMateria> _003areaMateria { get; set; } = new List<_003areasMateria>();

    public virtual ICollection<_059tiposRecurso> _059tipoRecursos { get; set; } = new List<_059tiposRecurso>();
}
