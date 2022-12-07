namespace EnviosTLE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRODUCTO")]
    public partial class PRODUCTO
    {
        [Key]
        [StringLength(40)]
        public string ID_PRODUCTO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PESO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ALTO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ANCHO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LARGO { get; set; }

        [StringLength(200)]
        public string DESCRIPCION { get; set; }

        [Required]
        [StringLength(40)]
        public string ID_FACTURA { get; set; }

        public virtual FACTURA FACTURA { get; set; }
    }
}
