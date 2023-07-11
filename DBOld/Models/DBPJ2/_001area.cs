using System;
using System.Collections.Generic;

namespace DBOld.Models.DBPJ2;

public partial class _001area
{
    public int _001areaId { get; set; }

    public string _001nombre { get; set; } = null!;

    public string? _001alias { get; set; }

    public string? _001abreviatura { get; set; }

    public int? _001areaIdEquitas { get; set; }

    public int? _001areaIdMajat { get; set; }

    public int? _001areaEvaluacionesId { get; set; }

    public int? _001areaIdArchivo { get; set; }

    public int? _009partidoJudicialId { get; set; }

    public int? _010municipioId { get; set; }

    public bool _001activo { get; set; }

    public string? _001correoElectronico { get; set; }

    public virtual ICollection<_003areasMateria> _003areasMateria { get; set; } = new List<_003areasMateria>();

    public virtual _009partidosJudiciale? _009partidoJudicial { get; set; }

    public virtual _010municipio? _010municipio { get; set; }

    public virtual ICollection<_020sala> _020salas { get; set; } = new List<_020sala>();

    public virtual ICollection<_040tiposDepartamentosArea> _040tiposDepartamentosAreas { get; set; } = new List<_040tiposDepartamentosArea>();

    public virtual ICollection<_063areasSistema> _063areasSistemas { get; set; } = new List<_063areasSistema>();

    public virtual ICollection<_058tiposTocasOrale> _058tipoTocaOrals { get; set; } = new List<_058tiposTocasOrale>();
}
