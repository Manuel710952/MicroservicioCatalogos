using System;
using System.Collections.Generic;

namespace DBOld.Models.DBPJ;

public partial class _060tiposCategoriasPuesto
{
    public int _060tipoCategoriaPuestoId { get; set; }

    public string _060nombre { get; set; } = null!;

    public bool _060activo { get; set; }

    public DateTime? _060fechaInicial { get; set; }

    public DateTime? _060fechaFinal { get; set; }

    public virtual ICollection<_045puesto> _045puestos { get; set; } = new List<_045puesto>();

    public virtual ICollection<_068puestosOficiale> _068puestosOficiales { get; set; } = new List<_068puestosOficiale>();
}
