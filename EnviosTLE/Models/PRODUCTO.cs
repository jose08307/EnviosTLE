using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EnviosTLE.Models
{
    [Serializable]
    [Table(nameof(CLIENTE), Schema = "DB_TLE")]
    public class PRODUCTO
    {
        [Key]
        public string ID_PRODUCTO { get; set; }
        public decimal PESO { get; set; }
        public decimal? ALTO { get; set; }
        public decimal? ANCHO { get; set; }
        public decimal? LARGO { get; set; }
        public string DESCRIPCION { get; set; }

        [ForeignKey("FACTURA")]
        public string ID_FACTURA { get; set; }


        public virtual FACTURA FACTURA { get; set; }
    }
}

