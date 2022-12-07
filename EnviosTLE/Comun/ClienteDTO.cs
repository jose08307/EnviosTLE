using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnviosTLE.Comun
{
    public class ClienteDTO
    {
        public string ID_CLIENTE { get; set; }
        public decimal IDENTIFICACION { get; set; }
        public string NOMBRES { get; set; }
        public string CIUDAD { get; set; }
        public string APELLIDOS { get; set; }
        public string DIRECCION { get; set; }
        public string TELEFONO { get; set; }
        public string TIPO { get; set; }
        public string ID_FACTURA { get; set; }

    }
}