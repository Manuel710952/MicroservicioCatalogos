using System;
using System.Collections.Generic;

namespace DBOld.Models.DBPJ2;

public partial class _045puesto
{
    public int _045puestoId { get; set; }

    public string _045nombre { get; set; } = null!;

    public bool _045activo { get; set; }

    public DateTime _045fechaRegistro { get; set; }

    public int _045usuarioQuienRegistro001dbcuentas { get; set; }

    public int _044tipoPuestoId { get; set; }

    public int? _052nivelPuestoId { get; set; }

    public int? _060tipoCategoriaPuestoId { get; set; }

    public DateTime? _045fechaInicial { get; set; }

    public DateTime? _045fechaFinal { get; set; }

    public bool? _045muestraAutografa { get; set; }

    public int? _068puestoOficialId { get; set; }

    public virtual _044tiposPuesto _044tipoPuesto { get; set; } = null!;

    public virtual _052nivelesPuesto? _052nivelPuesto { get; set; }

    public virtual _060tiposCategoriasPuesto? _060tipoCategoriaPuesto { get; set; }

    public virtual _068puestosOficiale? _068puestoOficial { get; set; }

    public virtual ICollection<_040tiposDepartamentosArea> _040tipoDepartamentoAreas { get; set; } = new List<_040tiposDepartamentosArea>();
}
