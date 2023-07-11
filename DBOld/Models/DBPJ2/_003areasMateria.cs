using System;
using System.Collections.Generic;

namespace DBOld.Models.DBPJ2;

public partial class _003areasMateria
{
    public int _003areaMateriaId { get; set; }

    public int _001areaId { get; set; }

    public int _002materiaId { get; set; }

    public virtual _001area _001area { get; set; } = null!;

    public virtual _002materia _002materia { get; set; } = null!;

    public virtual ICollection<_004tiposDocumento> _004tipoDocumentos { get; set; } = new List<_004tiposDocumento>();

    public virtual ICollection<_024tiposAudiencium> _024tipoAudiencia { get; set; } = new List<_024tiposAudiencium>();
}
