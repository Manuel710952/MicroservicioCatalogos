using System;
using System.Collections.Generic;

namespace DBOld.Models.DBPJ2;

public partial class _032tiposSistema
{
    public int _032tipoSistemaId { get; set; }

    public string _032nombre { get; set; } = null!;

    public bool? _032activo { get; set; }

    public string _032icono { get; set; } = null!;

    public string _032rutaDeAcceso { get; set; } = null!;

    public virtual ICollection<_031sistema> _031sistemas { get; set; } = new List<_031sistema>();
}
