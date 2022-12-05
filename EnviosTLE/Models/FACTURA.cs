using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EnviosTLE.Models
{
    [Serializable]
    [Table(nameof(FACTURA), Schema = "DB_TLE")]
    public class FACTURA
    {
        public string ID_FACTURA { get; set; }
        public DateTime FECHA { get; set; }
        public decimal VALOR { get; set; }

        public virtual ICollection<PRODUCTO> PRODUCTO { get; set; }
        public virtual ICollection<CLIENTE> CLIENTE { get; set; }

    }
}