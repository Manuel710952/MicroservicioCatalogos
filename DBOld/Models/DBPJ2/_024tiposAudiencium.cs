using System;
using System.Collections.Generic;

namespace DBOld.Models.DBPJ2;

public partial class _024tiposAudiencium
{
    public int _024tipoAudienciaId { get; set; }

    public string _024nombre { get; set; } = null!;

    public bool _024activo { get; set; }

    public int? _024tipoAudienciaIdSiop { get; set; }

    public int? _024tipoAudienciaIdEquitas { get; set; }

    public int? _002materiaId { get; set; }

    public virtual _002materia? _002materia { get; set; }

    public virtual ICollection<_003areasMateria> _003areaMateria { get; set; } = new List<_003areasMateria>();
}
