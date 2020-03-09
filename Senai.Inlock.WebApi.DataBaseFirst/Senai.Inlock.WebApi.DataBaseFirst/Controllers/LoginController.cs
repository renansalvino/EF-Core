using Microsoft.AspNetCore.Mvc;
using Senai.Inlock.WebApi.DataBaseFirst.Interfaces;
using Senai.Inlock.WebApi.DataBaseFirst.Repositories;
using Senai.Inlock.WebApi.DataBaseFirst.VieModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Inlock.WebApi.DataBaseFirst.Controllers
{
        [Produces("api/[controller]")]

        [ApiController]

        [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository { get; set; }

        public LoginController()
        {
            _usuarioRepository = new UsuarioRepository();

        }


        [HttpPost]
        public IActionResult _usuarioRepository.Cadastrar(LoginViewModel Login)
        {
            
        }
    }
}
