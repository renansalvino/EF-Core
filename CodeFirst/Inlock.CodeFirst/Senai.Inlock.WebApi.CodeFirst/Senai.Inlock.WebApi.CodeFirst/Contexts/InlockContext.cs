using Microsoft.EntityFrameworkCore;
using Senai.Inlock.WebApi.CodeFirst.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Inlock.WebApi.CodeFirst.Contexts
{
    /// <summary>
    /// Classe Responsável pelo contexto do projeto
    /// Faz a comunicação entre API e banco de dados
    /// </summary>
    public class InlockContext : DbContext
    {
        public DbSet<TiposUsuario> TiposUsuarios { get; set; }

        public int MyProperty { get; set; }
    }
}
