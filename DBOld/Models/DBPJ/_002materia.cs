using System;
using System.Collections.Generic;

namespace DBOld.Models.DBPJ;

public partial class _002materia
{
    public int _002materiaId { get; set; }

    public string _002nombre { get; set; } = null!;

    public int? _002materiaIdEquitas { get; set; }

    public int? _002materiaIdMajat { get; set; }

    public bool? _002activo { get; set; }

    public virtual ICollection<_003areasMateria> _003areasMateria { get; set; } = new List<_003areasMateria>();

    public virtual ICollection<_024tiposAudiencium> _024tiposAudiencia { get; set; } = new List<_024tiposAudiencium>();

    public virtual ICollection<_042juicio> _042juicios { get; set; } = new List<_042juicio>();

    public virtual ICollection<_029tiposPersonalidad> _029tipoPersonalidads { get; set; } = new List<_029tiposPersonalidad>();
}
