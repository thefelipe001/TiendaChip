namespace Model.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Chip")]
    public partial class Chip
    {
        public int ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Numero { get; set; }

        [Required]
        [StringLength(10)]
        public string Pink { get; set; }

        [Required]
        [StringLength(10)]
        public string Punk { get; set; }

        [Required]
        [StringLength(10)]
        public string Compañia { get; set; }
    }
}
