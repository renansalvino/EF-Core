using Senai.Inlock.WebApi.DataBaseFirst.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Inlock.WebApi.DataBaseFirst.Interfaces
{
    interface ITiposUsuariosRepository
    {
        List<TipoUsuario> Listar();

        Usuario BuscarPoId(int id);

        void Cadastar(TipoUsuario tipoUsuario);

        void Atualizar(TipoUsuario tipoUsuario, int id);

        void Deletar(int id);
    }
}
