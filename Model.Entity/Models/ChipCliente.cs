using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity.Models
{
    public class ChipCliente
    {
        public int IDChip { get; set; }

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


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Cedula { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string Apellido { get; set; }

        public int Edad { get; set; }

        [Required]
        [StringLength(50)]
        public string Direccion { get; set; }

        public int ChipId { get; set; }
    }
}