using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Inlock.WebApi.CodeFirst.Domains
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "O email tem de ser Obrigatório")]
        [Column("Email")]
        public string Email { get; set; }


        [Column("Senha")]
        public string Senha { get; set; }

        
        public int IdTipoUsuario {get;set;}

        //Chvae Estrangeira
        public TiposUsuario TipoUsuario { get; set; }
        
    }
}
