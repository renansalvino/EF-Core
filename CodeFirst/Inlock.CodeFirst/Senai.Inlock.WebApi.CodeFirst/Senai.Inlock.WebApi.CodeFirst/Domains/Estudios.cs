using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Inlock.WebApi.CodeFirst.Domains
{
    [Table("Estudios")]
    public class Estudios
    {
        [Key]
        public int IdEstudio { get; set; }

        [Required(ErrorMessage ="O nomme do estudio tem de ser Obrigatório")]
        public string NomeEstudio { get; set; }
    }
}
