using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Documentos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id_documento { get; set; }
        public int Id_area { get; set; }
        [ForeignKey("Id_area")]
        public virtual Area Area { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 

    }
}
