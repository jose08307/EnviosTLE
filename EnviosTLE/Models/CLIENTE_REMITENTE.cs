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
    [Table(nameof(CLIENTE_REMITENTE), Schema = "SYSTEM")]

    public class CLIENTE_REMITENTE
    {
        [Key]
        public decimal CEDULA { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public string DIRECCION { get; set; }
        public decimal TELEFONO { get; set; }
    }
}

