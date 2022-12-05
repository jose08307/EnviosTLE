using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnviosTLE.Comun
{
    public class ClienteRemitenteDTO
    {
        public decimal CEDULA { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public string DIRECCION { get; set; }
        public decimal TELEFONO { get; set; }

    }
}