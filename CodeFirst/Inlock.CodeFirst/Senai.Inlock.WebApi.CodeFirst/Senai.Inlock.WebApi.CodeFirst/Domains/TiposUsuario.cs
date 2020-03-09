using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Inlock.WebApi.CodeFirst.Domains
{
    [Table("TiposUsuario")]
    public class TiposUsuario
    {
        //Define que sera uma chave primaria
        [Key]

    //Define auto-incrementação
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int IdTipoUsuario { get; set; } 

        //Define o tipo da coluna do banco de dados
        [Column(TypeName ="VARCHAR (255)")]
        //Define que =o campo tem de ser obrigatório ou seja, um NOT NULL
        [Required(ErrorMessage ="O titulo do tipo usuario tem de ser obrigatório")]
        public int Titulo { get; set; }
    }
}
