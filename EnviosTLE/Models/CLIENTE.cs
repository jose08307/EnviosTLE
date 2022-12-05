using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EnviosTLE.Models
{
    [Serializable]
    [Table(nameof(CLIENTE), Schema = "DB_TLE")]

    public class CLIENTE
    {
        [Key]
        public string ID_CLIENTE { get; set; }
        public decimal IDENTIFICACION { get; set; }
        public string NOMBRES { get; set; }
        public string APELLIDOS { get; set; }
        public string DIRECCION { get; set; }
        public string TELEFONO { get; set; }
        public string TIPO { get; set; }

        [ForeignKey("FACTURA")]
        public string ID_FACTURA { get; set; }


        public virtual FACTURA FACTURA { get; set; }

    }
}