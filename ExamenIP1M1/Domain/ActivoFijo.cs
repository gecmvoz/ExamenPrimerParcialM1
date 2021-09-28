﻿using Domain.Enum;
using System;

namespace Domain
{
    public class ActivoFijo
    {
        public int Id { get; set;}
        public string CodigoActivo { get; set; }
        public string NombreActivo { get; set; }
        public string Descripcion { get; set;  }
        public decimal ValorActivo { get; set; }
        public DateTime FechaAdquisicion { get; set;  }
        public TipoActivoFijo TipoActivoFijo { get; set; }
        public MetodoDepreciacion MetodoDepreciacion { get; set; }
    }
}
