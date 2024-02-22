using System;
using System.Collections.Generic;

namespace PruebaTec03DEML.Models
{
    public partial class Ruta
    {
        public Ruta()
        {
            buses = new HashSet<bus>();
        }

        public int RutaId { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }

        public virtual ICollection<bus> buses { get; set; }
    }
}
