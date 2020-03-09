using Senai.Inlock.WebApi.DataBaseFirst.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Inlock.WebApi.DataBaseFirst.Interfaces
{
    interface IJogoRepository
    {
        List<Jogo> Listar();

        Jogo BuscarPorId(int id);

        Jogo Cadastrar(Jogo novoJogo);

        Jogo Atualizar(int id, Jogo jogo);

        void Deletar(int id);

        List<Estudio> ListarJogosPorEstudio(int id);
        
    }
}
