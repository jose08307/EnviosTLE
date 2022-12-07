namespace EnviosTLE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CLIENTE")]
    public partial class CLIENTE
    {
        [Key]
        [StringLength(40)]
        public string ID_CLIENTE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal IDENTIFICACION { get; set; }

        [Required]
        [StringLength(50)]
        public string NOMBRES { get; set; }

        [Required]
        [StringLength(50)]
        public string APELLIDOS { get; set; }

        [Required]
        [StringLength(50)]
        public string DIRECCION { get; set; }

        [Required]
        [StringLength(50)]
        public string CIUDAD { get; set; }

        [Required]
        [StringLength(50)]
        public string TELEFONO { get; set; }

        [Required]
        [StringLength(50)]
        public string TIPO { get; set; }

        [Required]
        [StringLength(40)]
        public string ID_FACTURA { get; set; }

        public virtual FACTURA FACTURA { get; set; }
    }
}
