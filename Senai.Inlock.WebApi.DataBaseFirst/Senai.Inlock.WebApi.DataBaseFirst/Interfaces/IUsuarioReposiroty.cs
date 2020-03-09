using Senai.Inlock.WebApi.DataBaseFirst.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Inlock.WebApi.DataBaseFirst.Interfaces
{
    interface IUsuarioRepository
    {
        List<Usuario> Listar();

        Usuario BuscarPorId(int id);

        void Cadastar(Usuario usuario);

        void Atualizar(Usuario usuario, int id);

        void Deletar(int id);



    }
}
