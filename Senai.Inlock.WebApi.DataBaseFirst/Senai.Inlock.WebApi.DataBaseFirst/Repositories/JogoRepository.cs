using Senai.Inlock.WebApi.DataBaseFirst.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Inlock.WebApi.DataBaseFirst.Repositories
{
    public class JogoRepository
    {
        InLockContext ctx = new InLockContext();

        public List<Jogo> Listar()
        {
            return ctx.Jogo.ToList();
        }

        public Jogo BuscarPorId(int id)
        {
            return ctx.Jogo.FirstOrDefault(e => e.IdJogo == id);
        }

        public Jogo Cadastrar(Jogo novoJogo)
        {
            ctx.Jogo.Add(novoJogo);
            ctx.SaveChanges(true);
            return novoJogo;
        }

        public void Deletar(int id)
        {
            Jogo jogo = new Jogo();

            jogo = BuscarPorId(id);

            ctx.Jogo.Remove(jogo);
        }

        public void List<Estudio> ()
        {
            var groupjoin = ctx.Estudio.GroupJoin(ctx.Jogo,
                e => e.IdEstudio,
                j => j.IdJogo,
                (j, jogosGrupo) => new
                {
                    Jogo = jogosGrupo,
                    Nome = j.NomeEstudio,
                });

            foreach (var item in groupjoin)
            {
                Console.WriteLine(item.Nome);

                foreach (var stud in item.Jogo)
                    Console.WriteLine($"\t {stud.NomeJogo}");
            }
        }

    }
}


