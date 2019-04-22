using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace lista_presenca.Models
{
    public class People
    {
        [Key]
        public int matricula { get; set; }
        [Required]
        [Column(TypeName ="nvarchar(100)")]
        public string nome { get; set; }
        [Required]
        [Column(TypeName = "varchar(1)")]
        public string sexo { get; set; }
        [Required]
        [Column(TypeName = "varchar(2)")]
        public int idade { get; set; }
        [Required]
        [Column(TypeName = "varchar(60)")]
        public string curso { get; set; }
        [Required]
        [Column(TypeName = "varchar(2)")]
        public string semestre { get; set; }
    }
}
