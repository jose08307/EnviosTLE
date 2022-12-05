using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnviosTLE.Comun
{
    public class ProductoDTO
    {
        public string ID_PRODUCTO { get; set; }
        public decimal PESO { get; set; }
        public decimal? ALTO { get; set; }
        public decimal? ANCHO { get; set; }
        public decimal? LARGO { get; set; }
        public string DESCRIPCION { get; set; }
        public string ID_FACTURA { get; set; }

    }
}