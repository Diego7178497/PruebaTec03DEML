using System;
using System.Collections.Generic;

namespace PruebaTec03DEML.Models
{
    public partial class bus
    {
        public int AutobusId { get; set; }
        public string Modelo { get; set; } = null!;
        public string Placa { get; set; } = null!;
        public int? CapacidadPasajeros { get; set; }
        public byte[]? Imagen { get; set; }
        public int? RutaId { get; set; }

        public virtual Ruta? Ruta { get; set; }
    }
}
