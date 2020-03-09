using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Inlock.WebApi.CodeFirst.Domains
{
    [Table("Jogos")]
    public class Jogo
    {
        [Key]
        public int IdJogo { get; set; }

        [Required(ErrorMessage = "Nome do Jogo tem de ser obrigatório")]
        public string NomeJogo { get; set; }

        
        public string Descricao { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }
        
        [Column("Preço", TypeName = "DECIMAL (18,2)")]
        public decimal Valor { get; set; }

        public int Estudios { get; set; }

        [ForeignKey("IdEstudio")]
        public Estudios Estudio { get; set; }

        
    }
}
