using Microsoft.AspNetCore.Mvc;
using Senai.Inlock.WebApi.DataBaseFirst.Domain;
using Senai.Inlock.WebApi.DataBaseFirst.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Inlock.WebApi.DataBaseFirst.Repositories
{
    public class EstudioRepository : ControllerBase
    {
        
            InLockContext ctx = new InLockContext();

            
            public Estudio BuscarPorId(int id)
            {
                // Retorna o primeiro estúdio encontrado para o ID informado
                return ctx.Estudio.FirstOrDefault(e => e.IdEstudio == id);
            }

            
            public void Cadastrar(Estudio ESTDUINOVO)
            {
                // Adiciona este novoEstudio
                ctx.Estudio.Add(ESTDUINOVO);
                // Salva as informações para serem gravadas no banco de dados
                ctx.SaveChanges();
            }

            /// <summary>
            /// Lista todos os estúdios
            /// </summary>
            /// <returns>Uma lista de estúdios</returns>
            public List<Estudio> Listar()
            {
                // Retorna uma lista com todas as informações dos estúdios
                return ctx.Estudio.ToList();
            }
        }
}
