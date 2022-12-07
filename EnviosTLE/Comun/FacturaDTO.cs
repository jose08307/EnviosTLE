using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnviosTLE.Comun
{
    public class FacturaDTO
    {
        public string ID_FACTURA { get; set; }
        public DateTime FECHA { get; set; }
        public decimal VALOR { get; set; }
        public decimal CODIGO { get; set; }



        public string ID_PRODUCTO { get; set; }
        public decimal PESO { get; set; }
        public decimal? ALTO { get; set; }
        public decimal? ANCHO { get; set; }
        public decimal? LARGO { get; set; }
        public string DESCRIPCION { get; set; }


        public string ID_CLIENTE { get; set; }
        public decimal IDENTIFICACION { get; set; }
        public string NOMBRES { get; set; }
        public string APELLIDOS { get; set; }
        public string DIRECCION { get; set; }
        public string DIRECCION_DES { get; set; }
        public string DIRECCION_ORI { get; set; }
        public string TELEFONO { get; set; }
        public string TIPO { get; set; }

        public List<ClienteDTO> ListaClientes { get; set; }
        public List<ProductoDTO> ListaProducto { get; set; }
    }
}