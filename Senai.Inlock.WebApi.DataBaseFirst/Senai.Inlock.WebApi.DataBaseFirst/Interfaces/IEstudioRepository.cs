using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Senai.Inlock.WebApi.DataBaseFirst.Domain;

namespace Senai.Inlock.WebApi.DataBaseFirst.Interfaces
{
    interface IEstudioRepository
    {
        List<Estudio> Listar();

        Estudio Cadastrar(Estudio novoEstudio);

        List<Estudio> ListarPorJogos ();

        Estudio BuscarPorId(int id);

        Estudio Atualizar(Estudio estudio);

        Estudio Deletar(int id);
    }
}
