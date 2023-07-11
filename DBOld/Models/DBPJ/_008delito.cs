using System;
using System.Collections.Generic;

namespace DBOld.Models.DBPJ;

public partial class _008delito
{
    public int _008delitoId { get; set; }

    public string? _008nombre { get; set; }

    public int? _008delitoIdMajat { get; set; }

    public int? _008delitoIdEquitas { get; set; }

    public int? _033tipoBienJuridicoId { get; set; }

    public string? _008codigo { get; set; }

    public bool _008activo { get; set; }

    public virtual _033tiposBienJuridico? _033tipoBienJuridico { get; set; }

    public virtual ICollection<_013tiposDelito> _013tipoDelitos { get; set; } = new List<_013tiposDelito>();

    public virtual ICollection<_053articulo> _053articulos { get; set; } = new List<_053articulo>();
}
